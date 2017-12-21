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
using MySql.Data;

namespace eparkmo.admin.wallet_request
{
    public partial class pending : UserControl
    {
        private MySqlConnection con;
        public pending()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
            DisplayFixer();
            displayWalletRequest();
        }
        public void displayWalletRequest()
        { 
            string qry = "SELECT * "+
                "FROM wallet_payments "+
                "WHERE status = 'pending'";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close(); 
        }


        public void DisplayFixer()
        {
            //get height & Width 
            int scr_height = SystemInformation.VirtualScreen.Height;
            int scr_width = SystemInformation.VirtualScreen.Width;

            ////setting this form size depending on the screen size
            this.Width = scr_width;
            this.Height = scr_height - (65 + 24 + 22);
        }

        private void pending_Load(object sender, EventArgs e)
        {

        }
    }
}
