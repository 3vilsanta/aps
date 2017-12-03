using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eparkmo
{
    class ENV
    {
        public static string SERVER_URL= "http://192.168.43.224:8000/";
        public static string TERMS_AND_CONDITION = "http://sample.url/";
        static string _datasource = Properties.Settings.Default.server;
        static string _port = Properties.Settings.Default.port;
        static string _username = Properties.Settings.Default.username;
        static string _password = Properties.Settings.Default.password;
        static string _database = Properties.Settings.Default.database;
        static string _datetime = Properties.Settings.Default.datetime;


        public string constr =
            "Datasource=" + _datasource + "; " +
            "Port=" + _port + "; " +
            "Username=" + _username + "; " +
            "Password=" + _password + "; " +
            "Database=" + _database + "; " +
            "Convert Zero DateTime=" + _datetime + "; ";
    }
}
