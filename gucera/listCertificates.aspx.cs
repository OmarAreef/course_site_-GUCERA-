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
    public partial class listCertificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand prof = new SqlCommand("viewCertificate", conn);
            prof.CommandType = CommandType.StoredProcedure;
            Int32 Cid = Int32.Parse(CourseID.Text);
            prof.Parameters.Add(new SqlParameter("@cid", Cid));
            prof.Parameters.Add(new SqlParameter("@side", Session["user"]));
            conn.Open();
            GridView grid = new GridView();
            grid.DataSource = prof.ExecuteReader();
            grid.DataBind();
            form1.Controls.Add(grid);
            conn.Close();
        }
    }
}