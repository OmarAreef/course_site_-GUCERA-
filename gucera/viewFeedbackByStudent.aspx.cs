using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class viewFeedbackByStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewFeedback = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
            viewFeedback.CommandType = CommandType.StoredProcedure;

           
            int courseId = Int16.Parse(courseID.Text);

            viewFeedback.Parameters.Add(new SqlParameter("@instrId", Session["user"]));
            viewFeedback.Parameters.Add(new SqlParameter("@cid", courseId));



            conn.Open();
            SqlDataReader rdr = viewFeedback.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int Number = rdr.GetInt32(rdr.GetOrdinal("number"));
                Label number = new Label();
                number.Text = "Feedback NO.: " + Number + " | ";
                form1.Controls.Add(number);

                String Comment = rdr.GetString(rdr.GetOrdinal("comment"));
                Label comment = new Label();
                comment.Text = "Comment: " + Comment + " | " ;
                form1.Controls.Add(comment);

                int NumberOflikes = rdr.GetInt32(rdr.GetOrdinal("numberOfLikes"));
                Label numberOfLikes = new Label();
                numberOfLikes.Text = "NO. of Likes: " + NumberOflikes + " <br> ";
                form1.Controls.Add(numberOfLikes);

            }
        }
    }
}