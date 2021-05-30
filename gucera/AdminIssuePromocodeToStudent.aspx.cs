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
    public partial class AdminIssuePromocodeToStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int sid = Int16.Parse(StudentID.Text);
            String pid = PromocodeID.Text;

            SqlCommand issuePromocode = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            issuePromocode.CommandType = CommandType.StoredProcedure;
            issuePromocode.Parameters.Add(new SqlParameter("@sid", sid));
            issuePromocode.Parameters.Add(new SqlParameter("@pid", pid));

            conn.Open();
            issuePromocode.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("promocode is issued successfully");
            Response.Redirect("AdminHome.aspx");


        }
    }
}