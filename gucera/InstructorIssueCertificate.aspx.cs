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
    public partial class InstructorIssueCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int cid = Int16.Parse(CourseID.Text);
            int sid = Int16.Parse(StudentID.Text);
           
            DateTime issueDate = DateTime.Parse(IssueDate.Text);

            SqlCommand issueCertificate = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            issueCertificate.CommandType = CommandType.StoredProcedure;
            issueCertificate.Parameters.Add(new SqlParameter("@cid", cid));
            issueCertificate.Parameters.Add(new SqlParameter("@sid", sid));
            issueCertificate.Parameters.Add(new SqlParameter("@insId", Session["user"]));
            issueCertificate.Parameters.Add(new SqlParameter("@issueDate", issueDate));

            conn.Open();
            issueCertificate.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("certificate is issued successfully");


        }
    }
}