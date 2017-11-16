﻿using System;
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
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace eparkmo
{
    public partial class login : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager;
        public login()
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

        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string pass = txt_password.Text.Trim();


            try
            {
                if(email != "" && pass != "")
                {
                    var client = new RestClient(ENV.SERVER_URL);
                    var request = new RestRequest("login", Method.POST);
                    request.AddParameter("email", email); // adds to POST or URL querystring based on Method
                    request.AddParameter("password", pass);
                    // execute the request
                    client.Proxy = null;
                    IRestResponse response = client.Execute(request);
                    var content = response.Content; // raw content as string

                    JObject obj = JObject.Parse(content);
                    Boolean result = Boolean.Parse(obj["error"].ToString());

                    if (result)
                    {
                        MessageBox.Show(obj["error_msg"].ToString());
                    }
                    else
                    {
                        string uid = obj["uid"].ToString();
                        string user_role = obj["user"]["user_role_id"].ToString();

                        //if user_role is = 1 , means admin
                        //if user_role is = 2 , means employee

                        logged_user.user_id = int.Parse( obj["uid"].ToString());
                        logged_user.email = obj["user"]["email"].ToString();

                        if (user_role == "1")
                        {
                            this.Hide();
                            admin.index i = new admin.index();
                            i.Show();
                        }
                        else if (user_role == "2")
                        {
                            this.Hide();
                            employee.index i = new employee.index();
                            i.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unkown User");
                        } 
                    }
                }
                else
                {
                    MessageBox.Show("Username/Password is Required!");
                } 
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            } 
        }

        private void btn_forgotpassword_Click(object sender, EventArgs e)
        {
            Form x = new forgot_password.reset();
            x.ShowDialog();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
