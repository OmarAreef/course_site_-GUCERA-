using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class InstructorViewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewAssignments = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewAssignments.CommandType = CommandType.StoredProcedure;

            
            int courseId = Int16.Parse(CourseID.Text);

            viewAssignments.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            viewAssignments.Parameters.Add(new SqlParameter("@cid", courseId));



            conn.Open();
            SqlDataReader rdr = viewAssignments.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int studentID = rdr.GetInt32(rdr.GetOrdinal("sid"));
                Label sid = new Label();
                sid.Text ="Student ID: " + studentID + " | ";
                form1.Controls.Add(sid);

                int courseID = rdr.GetInt32(rdr.GetOrdinal("cid"));
                Label cid = new Label();
                cid.Text = "Course ID: " + courseID + " | ";
                form1.Controls.Add(cid);

                int AssignmentNumber = rdr.GetInt32(rdr.GetOrdinal("assignmentNumber"));
                Label assignmentNumber = new Label();
                assignmentNumber.Text ="Number :" +  AssignmentNumber + " | ";
                form1.Controls.Add(assignmentNumber);

                String AssignmentType = rdr.GetString(rdr.GetOrdinal("assignmenttype"));
                Label assignmenttype = new Label();
                assignmenttype.Text = AssignmentType;
                form1.Controls.Add(assignmenttype);
                decimal Grade;
                if (rdr.IsDBNull(rdr.GetOrdinal("grade")))
                {
                    Grade = 0;
                }
                else {
                    Grade = rdr.GetDecimal(rdr.GetOrdinal("grade"));
                        }
                Label grade = new Label();
                grade.Text = "Grade :" + Grade + "<br >";
                form1.Controls.Add(grade);

            }
        }
    }
}