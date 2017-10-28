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

namespace eparkmo.admin.employee
{
    public partial class master_list : UserControl
    {
        private MySqlConnection con;
        public master_list()
        {
            InitializeComponent();
            //--Connecting to Database------
            ENV i = new ENV();
            con = new MySqlConnection(i.constr);
            //------------------------------
            DisplayFixer();
            displayEmployee();
        }

        private void master_list_Load(object sender, EventArgs e)
        {

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

        public void displayEmployee()
        {
            //id
            //users_id 
            //assigned_area_code 
            //address 
            //gender 
            //created_at 
            //updated_at 

            string qry = "SELECT "+
                "(SELECT CONCAT(u.last_name , ', ', u.first_name, ' ' , u.middle_name) FROM users u WHERE u.id = users_id) as 'Fullname',"+
                "gender as 'Gender',"+
                "address as 'Address',"+
                "assigned_area_code as 'Area Code' "+
                "FROM employees"; 
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            con.Close();

        }

        private void btn_createemployee_Click(object sender, EventArgs e)
        {
            var x = new admin.employee.newEmployee();
            x.ShowDialog();
            displayEmployee();
        }
    }
}
