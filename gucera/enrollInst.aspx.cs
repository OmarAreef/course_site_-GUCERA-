using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace gucera
{
    public partial class enrollInst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void enroll_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int insid = Int16.Parse(instructor.Text);
            
            SqlCommand loginProc = new SqlCommand("enrollInCourse", conn);
            loginProc.CommandType = CommandType.StoredProcedure;
            loginProc.Parameters.Add(new SqlParameter("@sid",Session["user"]));
            loginProc.Parameters.Add(new SqlParameter("@instr", insid));
            loginProc.Parameters.Add(new SqlParameter("@cid", Session["cid"]));
            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            string msg = "Enrolled Successfully";
            MessageBox.Show(msg);
            Response.Redirect("StudentHome.aspx");


        }
    }
}