using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gucera
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewProfile.aspx");
        }

        protected void listCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("listCourses.aspx");
        }

        protected void addCredit_Click(object sender, EventArgs e)
        {
            Response.Redirect("addCredit.aspx");
        }

        protected void viewPromoCodes_Click(object sender, EventArgs e)
        {
            Response.Redirect("promoCode.aspx");
        }

        protected void viewAssign_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAssign.aspx");

        }

        protected void addFeedback_Click(object sender, EventArgs e)
        {
            Response.Redirect("addFeedback.aspx");
        }

        protected void listCertificates_Click(object sender, EventArgs e)
        {
            Response.Redirect("listCertificates.aspx");

        }

        protected void viewGrades_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssignmentGrades.aspx");
        }

        protected void subAssignment_Click(object sender, EventArgs e)
        {
            Response.Redirect("subAssignment.aspx");
        }

        protected void enroll_Click(object sender, EventArgs e)
        {
            Response.Redirect("enroll.aspx");
        }
    }
}