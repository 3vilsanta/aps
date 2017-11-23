using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace eparkmo.employee
{
    public partial class time_out : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager;
        public String id;

        DateTime time_in;
        DateTime ttime_out;
        string v_type;
        string plate_no;
        double totalHours;
        double fees=0;
        double cash=0;
        double change=0;

        public time_out()
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

        private void time_out_Load(object sender, EventArgs e)
        {
            string qry = "select * from transactions where id = " + id;
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            time_in = dt.Rows[0].Field<DateTime>("time_in");
            v_type = dt.Rows[0].Field<string>("vehicle_type");
            plate_no = dt.Rows[0].Field<string>("plate_number");


            lbl_timein.Text = time_in.ToString();
            lbl_plateno.Text = plate_no;

            lbl_fees.Text =  return_fees(time_in, v_type).ToString();
        }


        double return_fees(DateTime time_in, string vehicle_type)
        { 
            string qry = "Select * from parking_fees where costing_for=@cf";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            da.SelectCommand.Parameters.AddWithValue("cf", vehicle_type);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();

            int first_hours = dt.Rows[0].Field<int>("first_hours");
            double fee = dt.Rows[0].Field<double>("fee");
            double succeeding_hour_fee = dt.Rows[0].Field<double>("succeeding_hour_fee");

            ttime_out = DateTime.Now;
            lbl_timeout.Text = ttime_out.ToString();

            TimeSpan totalStay = ttime_out - time_in;
            double convertedtoDb = double.Parse(totalStay.TotalHours.ToString());
            totalHours = Math.Round(convertedtoDb, 0);

            lbl_totalhours.Text = totalHours.ToString();

            fees = 0;
            fees = fee;
            if (totalHours > first_hours) //if mas mataas sa unang tatlong oras
            { 
                double xx = totalHours - 3;

                fees += xx * succeeding_hour_fee;

            } 


            return fees;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            string qry = "UPDATE transactions SET time_out=@to," +
                "parking_fee=@fees,paid_amount=@cash,paid_change=@change WHERE id=@id";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@to", ttime_out);
            cmd.Parameters.AddWithValue("@fees", fees);
            cmd.Parameters.AddWithValue("@cash", cash);
            cmd.Parameters.AddWithValue("@change", change);
            cmd.Parameters.AddWithValue("@id",int.Parse(id));
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }

        private void txt_cash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsNumber(e.KeyChar)
               )
            {
                e.Handled = true;
            }
        }

        private void txt_cash_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_cash.Text != "")
            {
                change = 0;
                cash = double.Parse(txt_cash.Text);

                if(cash >= fees)
                {
                    change = cash - fees;

                    btn_timeout.Enabled = true;
                }
                else
                {
                    btn_timeout.Enabled = false;
                }
            }else
            {
                cash = 0;
                change = 0;
                
            } 

            lbl_change.Text = change.ToString("N2");
        }
    }
}
