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

namespace eparkmo.admin.clients
{
    public partial class users : UserControl
    {
        private MySqlConnection con;
        public users()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
            DisplayFixer();
            displayUsers();
        }

        public void displayUsers()
        {
            //$table->integer('users_id');
            //$table->double('wallet');
            //$table->string('cellphone_number');
            //$table->string('plate_number');
            //$table->string('vehicle_type');

            //$table->string('first_name');
            //$table->string('last_name');
            //$table->string('middle_name');
            //$table->string('email')->unique();
            //$table->string('password');
            //$table->string('profile_picture');
            //$table->integer('user_role_id');

            string qry = "SELECT "+
                "(SELECT UPPER(CONCAT(last_name,', ',first_name,' ',middle_name)) "+
                "FROM users u WHERE u.id = users_id) as 'Fullname',"+
                "(SELECT u.email " +
                "FROM users u WHERE u.id = users_id) as 'Email'," +
                "wallet as 'Available Wallet',vehicle_type as 'Vehicle type'," +
                "plate_number as 'Plate #' FROM clients";
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

        private void users_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
