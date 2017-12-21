using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace eparkmo.employee
{
    public partial class add_wallet : Form
    {
        private MySqlConnection con;
        public add_wallet()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
            panel1.Visible = false;
        }

        private void add_wallet_Load(object sender, EventArgs e)
        {

        }

        int uid;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email != "")
            {
                //procceed
                string qry = "select * from users where email=@email";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("email", email);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    uid = dr.GetInt16("id");
                    con.Close();

                    panel1.Visible = true;
                }else
                {
                    con.Close();
                    MessageBox.Show("Email not found");
                }
            }else
            {
                MessageBox.Show("Email is required");
            }
        }

        private void btnAddtoClient_Click(object sender, EventArgs e)
        {
            string amount = txtAmount.Text.Trim();

            if (amount != "")
            {
                double amt = double.Parse(amount);
                string qry = "UPDATE clients SET wallet=wallet + @wallet WHERE users_id=@uid";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.Parameters.AddWithValue("wallet", amt);
                cmd.Parameters.AddWithValue("uid", uid);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Success");
                panel1.Visible = false;
                txtAmount.Text = "";
            }else
            {
                MessageBox.Show("Need amount greater than zero");
            }

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsNumber(e.KeyChar)
              )
            {
                e.Handled = true;
            }
        }
    }
}
