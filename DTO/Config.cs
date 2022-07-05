using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Config
    {
        public static DataTable GetServerName()
        {
            DataTable table = SmoApplication.EnumAvailableSqlServers(true);
            return table;
        }

        public static DataTable GetDBName(string pServer, string pUser, string pPass)
        { 

            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
                "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " +
                pPass + "");
                da.Fill(dt);
            }
            catch
            {
                return null;
            }
            return dt;
        }
        public static int SaveConfig(string pServer, string pUser, string pPass, string pDBname)
        {
            Properties.Settings.Default.LTWNCConn = "Data Source=" + pServer +
            ";Initial Catalog=" + pDBname + ";User ID=" + pUser + ";pwd = " + pPass + "";
            Properties.Settings.Default.Save();

            ExampleAsync(Properties.Settings.Default.LTWNCConn);
            int result = Check_Config();
            return result;
        }

        public static int Check_Config()
        {

            Properties.Settings.Default.LTWNCConn = read();
            Properties.Settings.Default.Save();

            if (Properties.Settings.Default.LTWNCConn == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.LTWNCConn);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();

                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
        public static void ExampleAsync(string txt)
        {
            using (StreamWriter writetext = new StreamWriter(@"conn.txt"))
            {
                writetext.WriteLine(txt);
            }
        }
        public static string read()
        {
            if (!File.Exists(@"conn.txt"))
            {
                using (StreamWriter sw = File.CreateText(@"conn.txt")) ;
            }
            string user = "Everyone";

            DirectoryInfo myDirectoryInfo = new DirectoryInfo(@"conn.txt");
            DirectorySecurity myDirectorySecurity = myDirectoryInfo.GetAccessControl();
            myDirectorySecurity.AddAccessRule(new FileSystemAccessRule(user, FileSystemRights.FullControl, AccessControlType.Allow));
            myDirectoryInfo.SetAccessControl(myDirectorySecurity);
            using (StreamReader readtext = new StreamReader(@"conn.txt"))
            {
                string readText = readtext.ReadLine();
                return readText;
            }
        }
    }
}
