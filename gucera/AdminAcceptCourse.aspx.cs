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

namespace GUCera
{
    public partial class AdminAcceptCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int courseId = Int16.Parse(CourseID.Text);


            SqlCommand AdminAcceptCourse = new SqlCommand("AdminAcceptRejectCourse", conn);
            AdminAcceptCourse.CommandType = CommandType.StoredProcedure;
            AdminAcceptCourse.Parameters.Add(new SqlParameter("@adminId", Session["user"]));
            AdminAcceptCourse.Parameters.Add(new SqlParameter("@courseId", courseId));

            conn.Open();
            AdminAcceptCourse.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("course is accepted successfully");
            Response.Redirect("AdminHome.aspx");



        }
    }
}