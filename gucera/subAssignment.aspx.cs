using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace gucera
{
    public partial class subAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand prof = new SqlCommand("submitAssign", conn);
            prof.CommandType = System.Data.CommandType.StoredProcedure;
            Int32 cid = Int32.Parse(coureseID.Text);
            Int32 Number = Int32.Parse(number.Text);
            string Type = type.SelectedValue;
            prof.Parameters.Add(new SqlParameter("@assignnumber", Number));
            prof.Parameters.Add(new SqlParameter("@assignType", Type));
            prof.Parameters.Add(new SqlParameter("@cid", cid));
            prof.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            conn.Open();
            prof.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Assignmnet Submitted Successfully");
        }
    }
}