using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace eparkmo.employee
{
    public partial class index : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager;
        Thread update_History;

        String vehicle_type="";

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

            // timer_update.Enabled = true;
            this.update_History = new Thread(new ThreadStart(this.RealTimeHistory));
            this.update_History.Start(); 
        }

        private void RealTimeHistory()
        {
            string qry = "SELECT " +
               "id ," +
               "plate_number as 'Plate-#'," +
               "vehicle_type as 'Vehicle'," +
               "time_in as 'Time-IN'," +
               "time_out as 'Time-OUT' " +
               "FROM transactions " +
               "WHERE time_out > time_in";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
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
                "time_out as 'Time-OUT' " +
                "FROM transactions "+
                "WHERE time_out > time_in";
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
                "time_out as 'Time-OUT' " +
                "FROM transactions " +
                "WHERE time_out is null";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt); con.Close();
            dgv_active.DataSource = dt;
            dgv_active.Columns[0].Visible = false;
            
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {

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
            }else { con.Close();
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

        private void saveNewEntry(String plate_no)
        {
            try
            {
                var client = new RestClient(ENV.SERVER_URL);
                var request = new RestRequest("new_offline_reservation", Method.POST);
                request.AddParameter("users_id", 2); // adds to POST or URL querystring based on Method
                request.AddParameter("plate_no", plate_no);
                request.AddParameter("vehicle_type", vehicle_type);
                // execute the request
                client.Proxy = null;
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string
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
    }
}
