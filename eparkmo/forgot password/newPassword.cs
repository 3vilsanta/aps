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

namespace eparkmo.forgot_password
{
    public partial class newPassword : MaterialForm
    {
        public String email;
        private readonly MaterialSkinManager materialSkinManager; 
        public newPassword()
        {
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void newPassword_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string npass = txt_n_p.Text.Trim();//newpass
            string rnpass = txt_n_rp.Text.Trim();//retyped new pass

            if (npass.Length >= 6 && npass == rnpass)
            {
                try
                {
                    var client = new RestClient(ENV.SERVER_URL);
                    var request = new RestRequest("new_password", Method.POST);
                    request.AddParameter("email", email); // adds to POST or URL querystring based on Method
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
