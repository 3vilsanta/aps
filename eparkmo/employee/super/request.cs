using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;

namespace eparkmo.employee.super
{
    public partial class request : Form
    {
        int enCarCount = 0;
        int enMotorCount = 0;
        int exCarCount = 0;
        int exMotorCount = 0;
        private MySqlConnection con;

        public request()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
        }

        private void btnEntrance_Click(object sender, EventArgs e)
        {
            btnEntrance.Enabled = false;
            btnEnEnd.Enabled = true;
            serialPort1.Write("6"); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Enabled = false;
            btnExEnd.Enabled = true;
            serialPort1.Write("7"); 
        }

        private void request_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        } 

        private void request_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void btnEnEnd_Click(object sender, EventArgs e)
        { 
            //
            updateSlot(enCarCount, enMotorCount, "Entrance");
            txtEnCarCount.Text = "";
            txtEnMotorCount.Text = "";
            //--------------------
            serialPort1.Write("8");
            btnEntrance.Enabled = true;
            btnEnEnd.Enabled = false;
        }

        private void btnExEnd_Click(object sender, EventArgs e)
        { 
            //
            updateSlot(exCarCount, exMotorCount, "Exit");
            txtExCarCount.Text = "";
            txtExMotorCount.Text = "";
            //---------------------
            serialPort1.Write("9");
            btnExit.Enabled = true;
            btnExEnd.Enabled = false;

        }

        private void txtEnCarCount_KeyUp(object sender, KeyEventArgs e)
        {
            
            if(txtEnCarCount.Text.Trim() == "")
            {
                enCarCount = 0;
            }else
            {
                enCarCount = int.Parse(txtEnCarCount.Text.Trim());
            }
        }

        private void txtEnMotorCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsNumber(e.KeyChar)
              )
            {
                e.Handled = true;
            }
        }

        private void txtEnCarCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsNumber(e.KeyChar)
              )
            {
                e.Handled = true;
            }
        }

        private void txtExCarCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsNumber(e.KeyChar)
              )
            {
                e.Handled = true;
            }
        }

        private void txtExMotorCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsNumber(e.KeyChar)
              )
            {
                e.Handled = true;
            }
        }

        private void updateSlot(int car,int motor, string position)
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
                if (position == "Entrance")
                {
                    c_remaining -= car;
                    m_remaining -= motor; 
                }
                else
                {
                    c_remaining += car;
                    m_remaining += motor; 
                }


                //save slot update online
                string onQry = "update parking_lots set car_remaining=@cr, " +
                    "motorcycle_remaining=@mr";
                con.Open();
                MySqlCommand ucmd = new MySqlCommand(onQry, con);
                ucmd.Parameters.AddWithValue("cr", c_remaining);
                ucmd.Parameters.AddWithValue("mr", m_remaining);
                ucmd.ExecuteNonQuery();
                con.Close();


                //save slot update offline
                string constrr =
               "Datasource=localhost; " +
               "Port=3306; " +
               "Username=root; " +
               "Password=; " +
               "Database=aps_local; ";
                MySqlConnection conn = new MySqlConnection(constrr);

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

        private void txtEnMotorCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtEnMotorCount.Text.Trim() == "")
            {
                enMotorCount = 0;
            }
            else
            {
                enMotorCount = int.Parse(txtEnMotorCount.Text.Trim());
            }
        }

        private void txtExCarCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtExCarCount.Text.Trim() == "")
            {
                exCarCount = 0;
            }
            else
            {
                exCarCount = int.Parse(txtExCarCount.Text.Trim());
            }
        }

        private void txtExMotorCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtExMotorCount.Text.Trim() == "")
            {
                exMotorCount = 0;
            }
            else
            {
                exMotorCount = int.Parse(txtExMotorCount.Text.Trim());
            }
        }
    }
}
