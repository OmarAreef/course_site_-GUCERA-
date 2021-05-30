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
    public partial class gradeAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            
            int sid = Int16.Parse(StudentID.Text);
            int cid = Int16.Parse(CourseID.Text);
            int assignmentNumber = Int16.Parse(AssignmentNumber.Text);
            String type = Type.SelectedValue;
            decimal grade = decimal.Parse(Grade.Text);

            SqlCommand gradeAssign = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            gradeAssign.CommandType = CommandType.StoredProcedure;
            gradeAssign.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            gradeAssign.Parameters.Add(new SqlParameter("@sid", sid));
            gradeAssign.Parameters.Add(new SqlParameter("@cid", cid));
            gradeAssign.Parameters.Add(new SqlParameter("@assignmentNumber", assignmentNumber));
            gradeAssign.Parameters.Add(new SqlParameter("@type", type));
            gradeAssign.Parameters.Add(new SqlParameter("@grade", grade));

            conn.Open();
            gradeAssign.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("assignmnet is graded successfully");


        }
    }
}