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
using MySql.Data.MySqlClient;

namespace eparkmo.employee
{
    public partial class set_penalty : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager;
        public String transaction_id;
        public set_penalty()
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

        private void set_penalty_Load(object sender, EventArgs e)
        {

        }

        double cash, change,fee = 300;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text.Trim();
            string lname = txtLname.Text.Trim();
            
            if(fname != "" && lname!="" && txtCash.Text.Trim() != "" && txtChange.Text.Trim() != "")
            { 
                if(cash >= fee)
                {
                    string qry = "insert into "+
                        "penalty(transactions_id,fname,lname,fee,cash,cash_change,created_at,updated_at) "+
                        "values(@tid,@fname,@lname,@fee,@cash,@change,@ca,@ua)";
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("tid", transaction_id);
                    cmd.Parameters.AddWithValue("fname", fname);
                    cmd.Parameters.AddWithValue("lname", lname);
                    cmd.Parameters.AddWithValue("fee", fee);
                    cmd.Parameters.AddWithValue("cash", cash);
                    cmd.Parameters.AddWithValue("change", change);
                    cmd.Parameters.AddWithValue("ca", DateTime.Now);
                    cmd.Parameters.AddWithValue("ua", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("You have successfulu set a Penalty for this Transaction");
                    this.Close();
                }else
                {
                    MessageBox.Show("Cash must be higher than fee");
                }
                
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
               && !char.IsNumber(e.KeyChar)
              )
            {
                e.Handled = true;
            }
        }

        private void txtCash_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCash.Text != "")
            {
                change = 0;
                cash = double.Parse(txtCash.Text);

                if (cash >= fee)
                {
                    change = cash - fee;

                    btnSubmit.Enabled = true;
                }
                else
                {
                    btnSubmit.Enabled = false;
                }
            }
            else
            {
                cash = 0;
                change = 0;

            }

            txtChange.Text = change.ToString("N2");
        }
    }
}
