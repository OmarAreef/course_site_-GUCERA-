using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gucera
{
    public partial class addNumber : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addMobile_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string user = id.Text;
            string mobile = mob.Text;
            SqlCommand addMob = new SqlCommand("addMobile", conn);
            addMob.CommandType = CommandType.StoredProcedure;
            addMob.Parameters.Add(new SqlParameter("@ID", user));
            addMob.Parameters.Add(new SqlParameter("@mobile_number", mobile));
            conn.Open();
            addMob.ExecuteNonQuery();
            conn.Close();




        }
    }
}