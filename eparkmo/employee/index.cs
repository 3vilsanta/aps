using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System.Threading;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Printing;
using PrinterUtility;

using System.IO.Ports;
using System.Threading;

namespace eparkmo.employee
{
    public partial class index : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager; 

        int testt = 0;
        string vehicle_type="";
        string detected_vehicle_type = "";

        public index()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            
        }

        private void index_Load(object sender, EventArgs e)
        {
            
            displayHistory();
            displayActive();


            //connectArduino();


            begintoRead();


            //serialPort1.Close();
            timer_update.Start();


            //MessageBox.Show(
            //    logged_user.company_name + "\n" + 
            //    logged_user.company_address
            //    ); 

            //local connetion

            string constrr =
            "Datasource=localhost; " +
            "Port=3306; " +
            "Username=root; " +
            "Password=; " +
            "Database=aps_local; ";
             conn= new MySqlConnection(constrr);

            loadSlot();
        }

        void begintoRead()
        {
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            serialPort1.Open();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort sp = (SerialPort)sender;

            string w = sp.ReadLine();

            //string msg = sp.ReadExisting();
            if (w != String.Empty)
            {
                detected_vehicle_type = w.Trim();
                Invoke(new Action(() => txtVehicleType.Text = "Detected: "+ w));
            } 
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new admin.change_password();
            x.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new login();
            x.Show();
        }

        private void index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void displayHistory()
        { 
            //$table->increments('id');
            //$table->integer('client_id');
            //$table->integer('employee_id');
            //$table->integer('parking_lot_id');
            //$table->string('plate_number');
            //$table->string('vehicle_type');
            //$table->datetime('time_in');
            //$table->datetime('time_out');
            //$table->double('parking_fee');
            //$table->double('paid_amount');
            //$table->double('change');
            //$table->double('remaining_wallet_balance');
            //$table->timestamps();

            string qry = "SELECT " +
                "id ," + 
                "plate_number as 'Plate-#',"+
                "vehicle_type as 'Vehicle',"+
                "time_in as 'Time-IN',"+
                "time_out as 'Time-OUT',"+
                "trans_type as 'Type' " +
                "FROM transactions "+
                "WHERE time_out > time_in " +
                "ORDER BY time_in desc";
            con.Open(); 
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt); con.Close();
            this.dgv_history.DataSource = dt;
            this.dgv_history.Columns[0].Visible = false;
            
        }

        private void displayActive()
        {
            //$table->increments('id');
            //$table->integer('client_id');
            //$table->integer('employee_id');
            //$table->integer('parking_lot_id');
            //$table->string('plate_number');
            //$table->string('vehicle_type');
            //$table->datetime('time_in');
            //$table->datetime('time_out');
            //$table->double('parking_fee');
            //$table->double('paid_amount');
            //$table->double('change');
            //$table->double('remaining_wallet_balance');
            //$table->timestamps();

            string qry = "SELECT " +
                "id ," +
                "plate_number as 'Plate-#'," +
                "vehicle_type as 'Vehicle'," +
                "time_in as 'Time-IN'," +
                "time_out as 'Time-OUT', " +
                "trans_type as 'Type' " +
                "FROM transactions " +
                "WHERE time_out is null "+
                "ORDER BY time_in desc";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt); con.Close();
            dgv_active.DataSource = dt;
            dgv_active.Columns[0].Visible = false;
            
        }

        MySqlConnection conn;
        int countrr = 0;
        string o_uid;
        string o_position;
        private void timer_update_Tick(object sender, EventArgs e)
        {
            countrr++;
            lbl_output.Text = countrr.ToString();
            string qry = "SELECT * FROM client_requests";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(qry, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                o_uid = dr.GetString("user_id");
                o_position = dr.GetString("position");
                conn.Close();

                conn.Open();
                cmd = new MySqlCommand("DELETE FROM client_requests", conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                if(o_position == "Entrance")
                {
                    qry = "SELECT * FROM transactions " +
                    "WHERE client_id=(SELECT c.id from clients as c where c.users_id=@uid) AND time_in is null";
                    con.Open();
                    MySqlCommand ccmd = new MySqlCommand(qry, con);
                    ccmd.Parameters.AddWithValue("uid", int.Parse(o_uid));
                    MySqlDataReader ddr = ccmd.ExecuteReader();
                    if (ddr.Read())
                    {
                        int transaction_id = ddr.GetInt16("id");
                        con.Close();

                        string saveqry = "UPDATE transactions SET time_in=@now " +
                            "WHERE id=@id";
                        con.Open();
                        MySqlCommand saveCmd = new MySqlCommand(saveqry, con);
                        saveCmd.Parameters.AddWithValue("id", transaction_id);
                        saveCmd.Parameters.AddWithValue("now", DateTime.Now);
                        saveCmd.ExecuteNonQuery();
                        con.Close();
                        //MessageBox.Show(transaction_id.ToString());

                        //code here to open the gate
                        displayActive();

                        //vehicle_type
                        updateSlot("Car", o_position);
                        MessageBox.Show("New vehicle has been enter.");
                        
                        //
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("UnReserve User is trying to get in.", "System Message");
                    }
                }else if (o_position == "Exit")
                {

                }

                //serialPort1.Open();
                //serialPort1.Write("1");
                //serialPort1.Close();

            }
            else
            {
                conn.Close();
            }
           
        }

        private void updateSlot(string vehicle,string position)
        {
            string qry = "SELECT * FROM parking_lots";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int c_remaining;
                int m_remaining;

                c_remaining = dr.GetInt16("car_remaining");
                m_remaining = dr.GetInt16("motorcycle_remaining");

                con.Close();
                if(position == "Entrance")
                {
                    if (vehicle == "Motor")
                    {
                        m_remaining -= 1;
                    }
                    else if (vehicle == "Car")
                    {
                        c_remaining -= 1;
                    }
                }else
                {
                    if (vehicle == "Motor")
                    {
                        m_remaining += 1;
                    }
                    else if (vehicle == "Car")
                    {
                        c_remaining += 1;
                    }
                }
                

                //save slot update online
                string onQry = "update parking_lots set car_remaining=@cr, "+
                    "motorcycle_remaining=@mr";
                con.Open();
                MySqlCommand ucmd = new MySqlCommand(onQry, con);
                ucmd.Parameters.AddWithValue("cr", c_remaining);
                ucmd.Parameters.AddWithValue("mr", m_remaining);
                ucmd.ExecuteNonQuery();
                con.Close();


                //save slot update offline
                string ofQry = "update slots set car=@cr, " +
                    "motor=@mr";
                conn.Open();
                MySqlCommand uucmd = new MySqlCommand(ofQry, conn);
                uucmd.Parameters.AddWithValue("cr", c_remaining);
                uucmd.Parameters.AddWithValue("mr", m_remaining);
                uucmd.ExecuteNonQuery();
                conn.Close();

            }
            else
            {
                con.Close();
            }


        }

        private void loadSlot()
        {
            string qry = "SELECT * FROM parking_lots";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int c_remaining;
                int m_remaining;
                c_remaining = dr.GetInt16("car_remaining");
                m_remaining = dr.GetInt16("motorcycle_remaining");
                con.Close();

                // MessageBox.Show(c_remaining + " , " + m_remaining);
                //
                conn.Open();
                string savetoof = "INSERT INTO slots(car,motor) " +
                    "VALUES(@car,@motor)";
                MySqlCommand cmdd = new MySqlCommand(savetoof, conn);
                cmdd.Parameters.AddWithValue("@motor", m_remaining);
                cmdd.Parameters.AddWithValue("@car", c_remaining); 
                cmdd.ExecuteNonQuery();
                conn.Close();
                //
            }
            else
            {
                con.Close();
            }
        }
 

        private void lblRefreshActive_Click(object sender, EventArgs e)
        {
            displayActive();
        }

        private void lblRefreshHistory_Click(object sender, EventArgs e)
        {
            displayHistory();
        }

        private void displaToPrinter(
            String company_name,String company_address,
            String transaction_id,String plate_numner,
            String vehicle_type,DateTime time_in,
            DateTime time_out,Double cost,Double cash,
            Double change,String employee_name,String tc_link)
        {
             
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string plate_no = txtPlateNumber.Text.Trim();
            if (plate_no != "")
            {
                if (vehicle_type == "" || vehicle_type == "None")
                {
                    MessageBox.Show("No vehicle detected.", "Message");
                }
                else
                {
                    string qry = "SELECT * FROM transactions " +
                        "WHERE plate_number = @pn AND time_out is null";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("pn", plate_no);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        con.Close();
                        MessageBox.Show("Vehicle with this Plate # was already inside.", "Message");

                    }
                    else
                    {
                        con.Close();

                        DialogResult drr = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
                        if (drr == DialogResult.Yes)
                        {
                            vehicle_type = detected_vehicle_type;
                            saveNewEntry(plate_no);
                            //
                            serialPort1.Write("1");

                            //
                            displayActive();
                        }
                    }
                }
            }

        }

        private void saveNewEntry(string plate_no)
        {
            try
            {
                DateTime ti = DateTime.Now;
                DateTime to = DateTime.MinValue;

                string qry = "INSERT INTO transactions(employee_id,parking_lot_id," +
                    "plate_number,vehicle_type,time_in,trans_type) " +
                    "VALUES((SELECT id FROM employees WHERE users_id=@users_id)," +
                    "(SELECT id FROM parking_lots WHERE area_code=(SELECT assigned_area_code FROM employees WHERE users_id=@users_id))," +
                    "@pn,@vt,@ti,'Offline')";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("users_id", logged_user.user_id);
                cmd.Parameters.AddWithValue("pn", plate_no);
                cmd.Parameters.AddWithValue("vt", vehicle_type);
                cmd.Parameters.AddWithValue("ti", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();

                printMe(
                    logged_user.company_name,
                    logged_user.company_address,
                    plate_no,
                    vehicle_type,
                    ti,
                    to,
                    0,
                    0,
                    0,
                    "Offline",
                    logged_user.name,
                    ENV.TERMS_AND_CONDITION
                    );

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void txtPlateNumber_KeyUp(object sender, KeyEventArgs e)
        {  
            txtPlateNumber.Text = txtPlateNumber.Text.ToUpper();
            txtPlateNumber.SelectionStart = txtPlateNumber.Text.Length;
        }

        string textToPrint = "";
        private void printMe(
            string company_name,
            string company_address,
            string plate_no,
            string vehicle_type,
            DateTime time_in,
            DateTime time_out,
            double fee,
            double cash,
            double change,
            string trans_type,
            string employee_name,
            string tc_link)
        {
            //printer setup
            string printer_name = "pos";
            printDocument1.PrinterSettings.PrinterName = printer_name;


            double len;
            string spclen;
            string x;
            char xx = ' ';

            //headers     
            x = logged_user.company_name;
            len = x.Length;
            spclen = new string(xx, int.Parse(Math.Round((45 - len) / 2).ToString())); 
            c_name += spclen +  x + Environment.NewLine;


            x = logged_user.company_address;
            len = x.Length;
            spclen = new string(xx, int.Parse(Math.Round((45 - len) / 2).ToString()));
            //c_address += spclen + x + Environment.NewLine;
            c_address = x + Environment.NewLine;


            //body 
            textToPrint = "--------------------------------" + Environment.NewLine;

            //
            x = "Plate # : " + plate_no;
            textToPrint +=  Environment.NewLine;
            //

            textToPrint += "Vehicle Type : " + vehicle_type + Environment.NewLine;

            textToPrint += "Time IN : " + time_in.ToString() + Environment.NewLine;

            textToPrint += "Time OUT : " + time_out + Environment.NewLine;

            textToPrint += "Fee : " + fee.ToString("N2") + Environment.NewLine;

            textToPrint += "Cash : " + cash.ToString("N2") + Environment.NewLine;

            textToPrint += "Change : " + change.ToString("N2")  + Environment.NewLine;

            //footer  
            textToPrint += "--------------------------------" + Environment.NewLine;
            textToPrint += "Employee : " + logged_user.name + Environment.NewLine;
            textToPrint += "Terms & Condition" + Environment.NewLine;
            textToPrint += ENV.TERMS_AND_CONDITION + Environment.NewLine;
            textToPrint += " " + Environment.NewLine;
            textToPrint += " " + Environment.NewLine;
            textToPrint += "." + Environment.NewLine;

            //printing 
            try
            {
                //printDocument1.Print();
                //printPreviewControl1.Document.Dispose();
                printPreviewControl1.Document = printDocument1;
                printPreviewControl1.Zoom = 1;
                printPreviewControl1.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        string c_name, c_address;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.Clear(Color.White);

            e.Graphics.DrawString(c_name, new Font("Arial",8, FontStyle.Regular)
                , Brushes.Black, new Point(0,0));
            e.Graphics.DrawString(c_address, new Font("Arial", 8, FontStyle.Regular)
                , Brushes.Black, new Point(0, 10));
            e.Graphics.DrawString(textToPrint, new Font("Arial", 8, FontStyle.Regular)
               , Brushes.Black, new Point(0, 18)); 
        }
          
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort sp = (SerialPort)sender;
            //string indata = sp.ReadExisting();
            //vehicle_type = sp.ReadExisting();
        }

        private void timeOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgv_active.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();


                var form = new time_out();
                form.id = id;
                form.ShowDialog();

                displayActive();
                displayHistory();

                string qry = "select * from transactions where id=" + id;
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                printMe(
                    logged_user.company_name,
                    logged_user.company_address,
                    dt.Rows[0].Field<string>("plate_number"),
                    dt.Rows[0].Field<string>("vehicle_type"),
                    dt.Rows[0].Field<DateTime>("time_in"),
                    dt.Rows[0].Field<DateTime>("time_out"),
                    dt.Rows[0].Field<double>("parking_fee"),
                    dt.Rows[0].Field<double>("paid_amount"),
                    dt.Rows[0].Field<double>("paid_change"),
                    "Offline",
                    logged_user.name,
                    ENV.TERMS_AND_CONDITION
                    );
            }
        }


        public void connectArduino()
        {
            serialPort1.Close();

            serialPort1.PortName = "COM10";

            serialPort1.BaudRate = 9600;

            serialPort1.DataBits = 8;

            serialPort1.Parity = Parity.None;

            serialPort1.StopBits = StopBits.One;

            serialPort1.Handshake = Handshake.None;

            serialPort1.Encoding = System.Text.Encoding.Default;

            serialPort1.ReadTimeout = 10000;

            serialPort1.Open();
        }
    }
}
