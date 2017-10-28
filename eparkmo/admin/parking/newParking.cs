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

namespace eparkmo.admin.parking
{
    public partial class newParking : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private MySqlConnection con;
        public newParking()
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
        
        private void newParking_Load(object sender, EventArgs e)
        {

        }

        private void txtAreaCode_KeyUp(object sender, KeyEventArgs e)
        {
            txtAreaCode.Text = txtAreaCode.Text.ToUpper();
            txtAreaCode.SelectionStart = txtAreaCode.Text.Length;
        }

        private void txtCarCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsNumber(e.KeyChar)
               )
            {
                e.Handled = true;
            }
        }

        private void txtMotorCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsNumber(e.KeyChar)
               )
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkCode(txtAreaCode.Text.Trim())){

                //if has matched
                label1.Text = "Area code - is already taken";
                label1.ForeColor = Color.Red;
                txtAreaCode.Focus();

            }
            else
            {
                //id 
                //area_code 
                //car_capacity 
                //car_remaining 
                //motorcycle_capacity 
                //motorcycle_remaining 
                //status 
                //created_at 
                //updated_at 
                string qry = "INSERT INTO "+
                    "parking_lots(area_code,car_capacity,car_remaining,"+
                    "motorcycle_capacity,motorcycle_remaining,status,"+
                    "created_at,updated_at) "+
                    "VALUES(@ac,@cc,@cr,@mc,@mr,@s,@ca,@ua)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);

                cmd.Parameters.AddWithValue("ac", txtAreaCode.Text);
                cmd.Parameters.AddWithValue("cc", int.Parse(txtCarCapacity.Text));
                cmd.Parameters.AddWithValue("cr", int.Parse(txtCarCapacity.Text));
                cmd.Parameters.AddWithValue("mc", int.Parse(txtMotorCapacity.Text));
                cmd.Parameters.AddWithValue("mr", int.Parse(txtMotorCapacity.Text));
                cmd.Parameters.AddWithValue("s", "OFFLINE");
                cmd.Parameters.AddWithValue("ca", DateTime.Now);
                cmd.Parameters.AddWithValue("ua", DateTime.Now);
                cmd.ExecuteNonQuery();
                con.Close();

                this.Close();
            }
            
        }

        Boolean checkCode(string code)
        {
            Boolean result = false;
            string qry = "SELECT * FROM parking_lots WHERE area_code=@ac";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("ac", code);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                result = true;
            }
            con.Close();

            return result;
        }
    }
}
