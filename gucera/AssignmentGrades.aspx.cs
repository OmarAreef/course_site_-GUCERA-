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
    public partial class AssignmentGrades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void view_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand prof = new SqlCommand("viewAssignGrades", conn);
            prof.CommandType = System.Data.CommandType.StoredProcedure;
            Int32 cid = Int32.Parse(coureseID.Text);
            Int32 Number = Int32.Parse(number.Text);
            string Type = type.SelectedValue;
            SqlParameter success = prof.Parameters.Add("@assignGrade", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            
            prof.Parameters.Add(new SqlParameter("@assignnumber", Number));
            prof.Parameters.Add(new SqlParameter("@assignType", Type));
            prof.Parameters.Add(new SqlParameter("@cid", cid));
            prof.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            conn.Open();
            prof.ExecuteNonQuery();
            conn.Close();
            string Success = success.Value.ToString();
            string grade = "The grade of the Selected Assignment is:  " + Success;
            MessageBox.Show(grade);
            Response.Redirect("AssignmentGrades.aspx");
        }
    }
}