using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eparkmo.admin
{
    public partial class company : UserControl
    {
        private MySqlConnection con;

        public company()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
            loadData();
        }

        private void company_Load(object sender, EventArgs e)
        {

        }

        int cid;
        private void loadData()
        {
            string qry = "SELECT * FROM company WHERE id = 1";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader dr = cmd.ExecuteReader(); 
            if (dr.Read())
            {
                

                cid = int.Parse(dr.GetString("id"));
                txt_name.Text = dr.GetString("name");
                txt_address.Text = dr.GetString("address");


                con.Close();
            }
            else
            {
                con.Close();
            } 
        }

        private void updateData()
        {
            string name;
            string address;
            name = txt_name.Text.Trim();
            address = txt_address.Text.Trim();

            string qry = "UPDATE company SET "+
                "name=@name,address=@address,updated_at=@ua "+
                "WHERE id="+cid;
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("name", name);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("ua", DateTime.Now);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
          
        }

        private void txt_address_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        { 
            updateData();
        }
    }
}
