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
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace eparkmo.admin
{
    public partial class change_password : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public change_password()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void change_password_Load(object sender, EventArgs e)
        {

        }

        private void txt_o_p_KeyUp(object sender, KeyEventArgs e)
        {
            checkOldPassword();
        }

        private void checkOldPassword()
        {
            try
            {
                var client = new RestClient(ENV.SERVER_URL);
                var request = new RestRequest("check_password", Method.POST);
                request.AddParameter("email", logged_user.email); // adds to POST or URL querystring based on Method
                request.AddParameter("password", txt_o_p.Text.Trim().ToString());
                // execute the request
                IRestResponse response = client.Execute(request);
                var content = response.Content; // raw content as string 
                JObject obj = JObject.Parse(content);
                Boolean ifcheck = Boolean.Parse(obj["error"].ToString());
                if (!ifcheck)
                {
                    pb_result.BackgroundImage = Properties.Resources.ic_done_black_24dp;
                    pnl_new.Enabled = true;
                }
                else
                {
                    pb_result.BackgroundImage = Properties.Resources.ic_highlight_off_black_24dp;
                    pnl_new.Enabled = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string npass = txt_n_p.Text.Trim();//newpass
            string rnpass = txt_n_rp.Text.Trim();//retyped new pass

            if (npass.Length >= 6 && npass == rnpass)
            {
                try
                {
                    var client = new RestClient("http://localhost:8000/");
                    var request = new RestRequest("change_password", Method.POST);
                    request.AddParameter("id", logged_user.user_id); // adds to POST or URL querystring based on Method
                    request.AddParameter("password", npass);
                    // execute the request
                    IRestResponse response = client.Execute(request);
                    var content = response.Content; // raw content as string 
                                                    //JObject obj = JObject.Parse(content);

                    MessageBox.Show("New Password has been set.");
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                MessageBox.Show("Password must be..\n-Match!\n-Greater than or equal to 6 Characters");
                txt_n_p.Focus();
            }
        }
    }
}
