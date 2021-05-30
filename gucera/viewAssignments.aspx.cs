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
    public partial class viewAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewAssignmnets_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
         
            int cid = Int16.Parse(courseID.Text);

            SqlCommand viewAssign = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewAssign.CommandType = CommandType.StoredProcedure;
            viewAssign.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            viewAssign.Parameters.Add(new SqlParameter("@cid", cid));

            conn.Open();
            viewAssign.ExecuteNonQuery();
            conn.Close();
            Response.Write("action done successfully");

        }
    }
}