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
    public partial class viewParking : UserControl
    {
        private MySqlConnection con;
        public viewParking()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
            DisplayFixer();
            displayParkingArea();
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

        public void displayParkingArea()
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

            string qry = "SELECT id,area_code as 'Area Code',"+
                "car_capacity as 'Car capacity',car_remaining as 'Car remaining',"+
                "motorcycle_capacity as 'Motor capacity',"+
                "motorcycle_remaining as 'Motor remaining',"+
                "status as 'Online Status'" +
                " FROM parking_lots";
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            dgv.Columns[0].Visible = false;
            con.Close();

        }

        private void viewParking_Load(object sender, EventArgs e)
        {

        }

        private void btnNewParking_Click(object sender, EventArgs e)
        {
            var x = new admin.parking.newParking();
            x.ShowDialog();
            displayParkingArea();
        }
    }
}
