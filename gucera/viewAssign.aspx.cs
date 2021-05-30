using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gucera
{
    public partial class viewAssign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Int32 Cid = Int32.Parse( cid.Text);
            SqlCommand prof = new SqlCommand("viewAssign", conn);
            prof.CommandType = System.Data.CommandType.StoredProcedure;
            prof.Parameters.Add(new SqlParameter("@Sid", Session["user"]));
            prof.Parameters.Add(new SqlParameter("@CourseID", Cid));
            conn.Open();
            SqlDataReader rdr = prof.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                Label Course = new Label();
                Course.Text = "Course ID: " + Cid + " | ";
                form1.Controls.Add(Course);

                Int32 lastName = rdr.GetInt32(rdr.GetOrdinal("number"));
                Label lname = new Label();
                lname.Text = "Number: " + lastName + " | ";
                form1.Controls.Add(lname);

                String firstName = rdr.GetString(rdr.GetOrdinal("type"));
                Label fname = new Label();
                fname.Text = "Type: " + firstName + " | ";
                form1.Controls.Add(fname);
                
                Int32 id = rdr.GetInt32(rdr.GetOrdinal("fullGrade"));
                Label Id = new Label();
                Id.Text = "full Grade:  " + id.ToString() + " | ";
                form1.Controls.Add(Id);

                decimal weight = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                Label Weight = new Label();
                Weight.Text = "Weight:  " + weight.ToString() + " | ";
                form1.Controls.Add(Weight);

                DateTime expiryDate = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                Label expiry = new Label();
                DateTime exDate = Convert.ToDateTime(expiryDate);
                expiry.Text = "expiry Date: " + exDate + " | ";
                form1.Controls.Add(expiry);

                String content = rdr.GetString(rdr.GetOrdinal("content"));
                Label Content = new Label();
                Content.Text = "Content: " + content + "<br>   ";
                form1.Controls.Add(Content);



            }
        }
    }
}