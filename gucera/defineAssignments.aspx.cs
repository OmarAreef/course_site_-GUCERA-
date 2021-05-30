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
    public partial class defineAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void defineAssignment_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            
            int cid = Int16.Parse(courseID.Text);
            int number = Int16.Parse(Number.Text);
            String type = Type.SelectedValue;
            int fullGrade = Int16.Parse(FullGrade.Text);
            decimal weight = decimal.Parse(Weight.Text);
            DateTime deadline = DateTime.Parse(Deadline.Text);
            String content = Content.Text;

            SqlCommand define = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
            define.CommandType = CommandType.StoredProcedure;
            define.Parameters.Add(new SqlParameter("@instId", Session["user"]));
            define.Parameters.Add(new SqlParameter("@cid", cid));
            define.Parameters.Add(new SqlParameter("@number", number));
            define.Parameters.Add(new SqlParameter("@type", type));
            define.Parameters.Add(new SqlParameter("@fullGrade", fullGrade));
            define.Parameters.Add(new SqlParameter("@weight", weight));
            define.Parameters.Add(new SqlParameter("@deadline", deadline));
            define.Parameters.Add(new SqlParameter("@content", content));


            conn.Open();
            define.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("course is defined successfully");

        }
    }
}