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
    public partial class listCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand prof = new SqlCommand("availableCourses", conn);
            prof.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = prof.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {

                String firstName = rdr.GetString(rdr.GetOrdinal("name"));
                Label fname = new Label();
                fname.Text = "Course Name: " + firstName + " <br> ";
                form1.Controls.Add(fname);
            }

        }
    }
}