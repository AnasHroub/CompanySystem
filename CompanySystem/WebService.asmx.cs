using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Services;
using Newtonsoft.Json;

namespace CompanySystem
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string getDelegate()
        {
            string sql = "SELECT [ID],[Email],[Password],[Name],[Gender],[MartialStatus],[BirthDate],[PhoneNO],[Address] FROM Delegates";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return JsonConvert.SerializeObject(ds, Formatting.Indented);
        }

        [WebMethod]
        public void Insert(string Email, string Password, string Name, string Gender, string MartialStatus, string BirthDate, string PhoneNo, string Address)
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Insert Into Delegates(Email,Password,Name,Gender,MartialStatus, BirthDate,  PhoneNO, Address)Values(@P_Email, @P_Password, @P_Name, @P_Gender, @P_Martial_Status, @P_Birth_Date, @P_PHONE_NO, @P_Address)"))
                {
                    cmd.Parameters.AddWithValue("@P_Email", Email);
                    cmd.Parameters.AddWithValue("@P_Password", Password);
                    cmd.Parameters.AddWithValue("@P_Name", Name);
                    cmd.Parameters.AddWithValue("@P_Gender", Gender);
                    cmd.Parameters.AddWithValue("@P_Martial_Status", MartialStatus);
                    cmd.Parameters.AddWithValue("@P_Birth_Date", BirthDate);
                    cmd.Parameters.AddWithValue("@P_PHONE_NO", PhoneNo);
                    cmd.Parameters.AddWithValue("@P_Address", Address);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
