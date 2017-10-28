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
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Net;

namespace eparkmo.forgot_password
{
    public partial class reset : MaterialForm
    {
        private MySqlConnection con;
        private readonly MaterialSkinManager materialSkinManager;
        public reset()
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

        private void reset_Load(object sender, EventArgs e)
        {

        }


        public void alertMessage(string msg)
        {
            alertmsg = msg;
            x = 0;
            timer.Enabled = true;
        }
        int x = 0;
        string alertmsg;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (x <= 20)
            {
                lbl_msg.Text = alertmsg;
                lbl_msg.Visible = true;
                x++;
            }
            else
            {
                timer.Enabled = false;
                lbl_msg.Visible = false;
            }
        }

     

        private void txt_email_KeyUp(object sender, KeyEventArgs e)
        {
            string email = txt_email.Text.Trim();
            if (email != "")
            {
                bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (isEmail)
                {
                    try
                    {
                        string str = "SELECT * FROM users WHERE email=@email and user_role_id != 3";
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand(str, con);
                        cmd.Parameters.AddWithValue("@email", email);
                        MySqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            con.Close();
                            alertMessage("Email is good");
                            btnNext.Visible = true;
                        }
                        else
                        {
                            con.Close();
                            alertMessage("Email not found!");
                            btnNext.Visible = false;
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }
                    //-----  
                }
                else
                {
                    alertMessage("Invalid Email!");
                    btnNext.Visible = false;
                }
            }
            else
            {
                alertMessage("Email is required!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We've sent an Email verfication Code");
            tmr_countdown.Enabled = true;
            panel_nextpage.Visible = true;

            generatedPassword = generatePassword();
            //
            sendEmail(txt_email.Text.Trim(), generatedPassword);
            // 
            countdown = 60;
        }

        int countdown = 0;
        private void tmr_countdown_Tick(object sender, EventArgs e)
        {
            countdown--;
            if(countdown == 1 || countdown == 0)
            {
                lbl_countdown.Text = "[ " + countdown.ToString() + " Second Remaining.. ]";
            }
            else
            {
                lbl_countdown.Text = "[ " + countdown.ToString() + " Seconds Remaining.. ]";
            }
            
            if (countdown == 0)
            {
                tmr_countdown.Enabled = false;
            }

        }
        string generatedPassword;
        string generatePassword()
        {
            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");

            return r;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(countdown > 0)
            {
                if(txtCode.Text.Trim() == generatedPassword)
                {
                    MessageBox.Show("Code Accepted, You can now change your password.");
                    this.Hide();
                    var x = new forgot_password.newPassword();
                    x.email = txt_email.Text.Trim();
                    x.ShowDialog();
                }else
                {
                    MessageBox.Show("Invalid Code!");
                }
            }else
            {
                MessageBox.Show("Verification Code Already Expired");
            }
        }

        public void sendEmail(string email,string code)
        {
            try
            { 
                string myHost = Properties.Settings.Default.smtp_host;
                int myPort = int.Parse(Properties.Settings.Default.smtp_port);
                string myUsername = Properties.Settings.Default.smtp_username;
                string myPassword = Properties.Settings.Default.smtp_password;

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(myHost);

                mail.From = new MailAddress("SmartParking@developer.com");
                mail.To.Add(email);
                mail.Subject = "Password Recovery Code";
                mail.Body = "Hi!, Your Verification code is " + code + 
                    "\n\nPlease do not reply!";

                SmtpServer.Port = myPort;
                SmtpServer.Credentials = new System.Net.NetworkCredential(myUsername, myPassword);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
