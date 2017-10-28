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

namespace eparkmo.admin.parking
{
    public partial class viewParkingFee : UserControl
    {
        private MySqlConnection con;
        public viewParkingFee()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
            DisplayFixer();
            displayParkingFee();
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

        private void displayParkingFee()
        {
            // $table->integer('first_hours');
            // $table->double('fee');
            // $table->double('succeeding_hour_fee');
            // $table->string('costing_for');

            string qry = "SELECT id,"+
                "first_hours as 'First Hours', "+
                "fee as 'Fee', "+
                "succeeding_hour_fee as 'Succeeding Hour Fee', "+
                "costing_for as 'Costing For?',created_at as 'Created At' " +
                " FROM parking_fees";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;
            con.Close();
        }

        private void viewParkingFee_Load(object sender, EventArgs e)
        {

        }

        
    }
}
