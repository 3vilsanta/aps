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

namespace eparkmo.admin
{
    public partial class index : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager;
        public index()
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

        private void index_Load(object sender, EventArgs e)
        {

        }

        private void index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new aboutme.about();
            x.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = new admin.change_password();
            x.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new login();
            x.Show();
        }

        private void masterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employee_masterList = new admin.employee.master_list();
            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(employee_masterList);
        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Company";
            this.Refresh();
            var x = new  admin.company();
            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(x);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Parking";
            this.Refresh();
            var x = new admin.parking.viewParking();
            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(x);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new admin.parking.newParking();
            x.ShowDialog();
            //--
            this.Text = "Parking";
            this.Refresh();
            var z = new admin.parking.viewParking();
            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(z);
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            this.Text = "Parking";
            this.Refresh();
            var z = new admin.parking.viewParkingFee();
            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(z);
        }

        private void userslToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "User's Client";
            this.Refresh();
            var z = new admin.clients.users();
            pnl_display.Controls.Clear();
            pnl_display.Controls.Add(z);
        }
    }
}
