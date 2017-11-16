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

namespace eparkmo.employee
{
    public partial class index : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager; 

        int testt = 0;
        string vehicle_type="Motor";

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

            timer_update.Start();


            //MessageBox.Show(
            //    logged_user.company_name + "\n" + 
            //    logged_user.company_address
            //    ); 

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

        private void timer_update_Tick(object sender, EventArgs e)
        {
            testt++;
            txtVehicleType.Text = testt + " Detected Vehicle : " + vehicle_type;
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

            string qry = "SELECT * FROM transactions "+
                "WHERE plate_number = @pn AND time_out is null";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("pn", plate_no);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                MessageBox.Show("Vehicle with this Plate # was already inside.","Message");
            }else {
                con.Close();

                DialogResult drr = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);
                if (drr == DialogResult.Yes)
                {
                    saveNewEntry(plate_no);
                    displayActive();
                }

            }



            //String company_name = "Filinvest";
            //String company_address = "Northgate Cyberzone,";
            //String transaction_id = "0001";
            //String plate_number = "AC201";
            //String vehicle_type = "CAR";
            //DateTime time_in = DateTime.Now;
            //DateTime time_out = DateTime.Now; 
            //Double cost = 40, cash = 50, change = 10;
            //String employee_name ="David Gualvez", tc_link = "http://eparkmo.herokuapp.com/termsandcondition";
            //displaToPrinter(company_name, company_address, transaction_id,
            //    plate_number, vehicle_type, time_in, time_out, cost, cash, change, employee_name,
            //    tc_link);
        }

        private void saveNewEntry(string plate_no)
        {
            try
            {
                //MessageBox.Show(logged_user.user_id.ToString());
                //var client = new RestClient(ENV.SERVER_URL);
                //var request = new RestRequest("new_offline_reservation", Method.POST);
                //request.AddParameter("users_id", logged_user.user_id); // adds to POST or URL querystring based on Method
                //request.AddParameter("plate_no", plate_no);
                //request.AddParameter("vehicle_type", vehicle_type);
                //// execute the request
                //client.Proxy = null;
                //IRestResponse response = client.Execute(request);
                //var content = response.Content; // raw content as string


                //
                //$emp = Employee::where('users_id',$request->users_id)->first();
                //$pl = ParkingLot::where('area_code',$emp->assigned_area_code)->first();

                ////saving
                //$t = new Transaction;
                //$t->employee_id = $emp->id;
                //$t->parking_lot_id = $pl->id;
                //$t->plate_number = $request->plate_no;
                //$t->vehicle_type = $request->vehicle_type;
                //$t->time_in = Carbon::now();
                //$t->trans_type = "Offline";
                //$t->save();
                //

                DateTime ti = DateTime.Now;
                DateTime to = DateTime.MinValue;
                string qry = "INSERT INTO transactions(employee_id,parking_lot_id,"+
                    "plate_number,vehicle_type,time_in,trans_type) "+
                    "VALUES((SELECT id FROM employees WHERE users_id=@users_id),"+
                    "(SELECT id FROM parking_lots WHERE area_code=(SELECT assigned_area_code FROM employees WHERE users_id=@users_id)),"+
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
            PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();

            byte[] bytesValue = { };
            bytesValue = PrintExtensions.AddBytes(bytesValue, obj.Separator());
            bytesValue = PrintExtensions.AddBytes(bytesValue, obj.CharSize.DoubleWidth6());
            bytesValue = PrintExtensions.AddBytes(bytesValue, obj.FontSelect.FontA());
            bytesValue = PrintExtensions.AddBytes(bytesValue, obj.Alignment.Center());
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Hello World\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, obj.Separator());
            bytesValue = PrintExtensions.AddBytes(bytesValue, cutpage());

            PrinterUtility.PrintExtensions.Print(bytesValue, "\\\\DAVID\\pos");

            ////printer setup
            //string printer_name = "pos";
            //printDocument1.PrinterSettings.PrinterName = printer_name;
            //string textToPrint = "";


            //double len;
            //string spclen;
            //string x;

            ////headers 
            ////Dim StringToPrint As String = "David"
            ////Dim LineLen As Integer = StringToPrint.Length
            ////Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2)) 'This line is used to center text in the middle of the receipt
            ////TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine
            //x = company_name;
            //len = x.Length;
            //char xx = ' ';
            //spclen = new string(xx, int.Parse( Math.Round((33 - len) / 2).ToString()));
            //textToPrint += spclen + x + Environment.NewLine;

            ////body


            ////footer


            ////printing
            ////Dim printControl = New Printing.StandardPrintController
            ////PrintDocument1.PrintController = printControl
            ////Try
            ////    PrintDocument1.Print()
            ////Catch ex As Exception
            ////    MsgBox(ex.Message)
            ////End Try


            //try
            //{
            //    printDocument1.Print();
            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}


        }

        public byte[] cutpage()
        {
            List<byte> oby = new List<byte>();
            oby.Add(Convert.ToByte(Convert.ToChar(0x1D)));
            oby.Add(Convert.ToByte("V"));
            oby.Add((byte)66);
            oby.Add((byte)3);
            return oby.ToArray();
        }

        static int currentChar;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Static currentChar As Integer


            //Dim textfont As Font = New Font("Courier New", 10, FontStyle.Bold)
            Font textfont = new Font("Courier New", 10, FontStyle.Bold);

            //Dim h, w As Integer
            int h, w;
            //Dim left, top As Integer
            int left, top;

            //With PrintDocument1.DefaultPageSettings
            //    h = 0
            //    w = 0
            //    left = 0
            //    top = 0
            //End With 


            //Dim lines As Integer = CInt(Math.Round(h / 1))
            //Dim b As New Rectangle(left, top, w, h)
            //Dim format As StringFormat
            //format = New StringFormat(StringFormatFlags.LineLimit)
            //Dim line, chars As Integer


            //e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), textfont, New SizeF(w, h), format, chars, line)
            //e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, b, format)


            //currentChar = currentChar + chars
            //If currentChar < TextToPrint.Length Then
            //    e.HasMorePages = True
            //Else
            //    e.HasMorePages = False
            //    currentChar = 0
            //End If
        }
    }
}
