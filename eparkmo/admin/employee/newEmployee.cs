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


namespace eparkmo.admin.employee
{
    public partial class newEmployee : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private MySqlConnection con;
        public newEmployee()
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

        private void newEmployee_Load(object sender, EventArgs e)
        {
            loadParking();
        }
         
        private void loadParking()
        {
            string qry = "SELECT * FROM parking_lots";

            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                con.Close();

                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close(); 
                cmb_areacode.Items.Clear();
                //cmb_company.Items.Add("Select Company");
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    cmb_areacode.Items.Add(dt.Rows[x].Field<string>("area_code"));  
 
                }
                cmb_areacode.SelectedIndex = 0;
                
            }
            else
            {
                con.Close();
                cmb_areacode.Items.Clear();
                cmb_areacode.Items.Add("No Record");
                cmb_areacode.SelectedIndex = 0;
            }
        }

        private void cb_view_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_view.Checked == true)
            {
                txt_password.PasswordChar = '\0';
            }
            else if (cb_view.Checked == false)
            {
                txt_password.PasswordChar = '.';
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txt_fname.Text != "" && 
                txt_lname.Text != "" && 
                cmb_gender.SelectedIndex >= 0 &&
                txt_address.Text != "" &&
                txt_email.Text != "" && 
                txt_password.Text.Length >= 6 &&
                (cmb_areacode.Text != "" && cmb_areacode.Text != "No Record"))
            {
                //save here
                string fname = txt_fname.Text.Trim();
                string lname = txt_lname.Text.Trim();
                string gender = cmb_gender.Text;
                string address = txt_address.Text.Trim() ;
                string email = txt_email.Text.Trim() ;
                string password = txt_password.Text.Trim() ;
                string area_code = cmb_areacode.Text;

                if (!checkEmail(email))
                { 
                    var client = new RestClient(ENV.SERVER_URL);
                    var request = new RestRequest("new_employee", Method.POST);
                    request.AddParameter("fname", fname); // adds to POST or URL querystring based on Method
                    request.AddParameter("lname", lname);
                    request.AddParameter("gender", gender);
                    request.AddParameter("address", address);
                    request.AddParameter("email", email);
                    request.AddParameter("password", password);
                    request.AddParameter("area_code", area_code);
                    // execute the request
                    IRestResponse response = client.Execute(request);
                    //var content = response.Content; // raw content as string

                    //JObject obj = JObject.Parse(content);
                    //Boolean result = Boolean.Parse(obj["error"].ToString());
                    this.Close();
                }else
                {
                    MessageBox.Show("Email is already taken.", "System Message");
                }
                
            }
            else
            {
                MessageBox.Show("All field are required!","System Message");
            }
        }

        private Boolean checkEmail(string email)
        {
            string qry = "SELECT * FROM users WHERE email=@email";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("email", email);
            MySqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                con.Close();
                return true;
            }else
            {
                con.Close();
                return false;
            }

        }

    }
}
