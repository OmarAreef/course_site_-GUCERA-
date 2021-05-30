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
    public partial class addFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Int32 Cid = Int32.Parse(cid.Text);
            string Comment = comm.Text;
            SqlCommand registerProc = new SqlCommand("addFeedback", conn);
            registerProc.CommandType = CommandType.StoredProcedure;
            registerProc.Parameters.Add(new SqlParameter("@comment", Comment));
            registerProc.Parameters.Add(new SqlParameter("@cid", Cid));
            registerProc.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            conn.Open();
            registerProc.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Feedback Submitted Successfully");
            Response.Redirect("StudentHome.aspx");
        }
    }
}