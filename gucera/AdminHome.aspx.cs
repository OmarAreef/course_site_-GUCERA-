using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gucera
{
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void allCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("listAllCourses.aspx");
        }

        protected void nonCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("listAllCoursesNonAccepted.aspx");
        }

        protected void accCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAcceptCourse.aspx");
        }

        protected void createPromo_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreatePromocode.aspx");
        }

        protected void issuePromo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminIssuePromocodeToStudent.aspx");
        }
    }
}