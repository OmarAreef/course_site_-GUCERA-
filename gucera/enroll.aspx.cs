using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows;

namespace gucera
{
    public partial class enroll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            Int32 cid = Int32.Parse(courseId.Text);
            SqlCommand prof = new SqlCommand("courseInformation", conn);
            prof.CommandType = CommandType.StoredProcedure;
            prof.Parameters.Add(new SqlParameter("@id", cid));
            Session["cid"] = cid;
            conn.Open();
            GridView grid = new GridView();
            grid.DataSource = prof.ExecuteReader();
            grid.DataBind();
            form1.Controls.Add(grid);
            enrollin.Visible = true;
            Label fname = new Label();
            fname.Text =  " <br> ";
            form1.Controls.Add(fname);
            
        }

        protected void enroll_Click()
        {
            
            
        }

        protected void enrollin_Click(object sender, EventArgs e)
        {
            Response.Redirect("enrollInst.aspx");
        }
    }
}