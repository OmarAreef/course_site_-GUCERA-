using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gucera
{
    public partial class InstructorHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("courses.aspx");
        }

        protected void defAssign_Click(object sender, EventArgs e)
        {
            Response.Redirect("defineAssignments.aspx");
        }

        protected void viewAssign_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorViewAssignments.aspx");
        }

        protected void gradeAssign_Click(object sender, EventArgs e)
        {
            Response.Redirect("gradeAssignments.aspx");
        }

        protected void viewFeed_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewFeedbackByStudent.aspx");
        }

        protected void issueCert_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstructorIssueCertificate.aspx");
        }
    }
}