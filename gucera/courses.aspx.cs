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
    public partial class couses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void addCourse_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String name = courseName.Text;
            int creditHours = Int16.Parse(creditHour.Text);
            decimal price = decimal.Parse(Price.Text);
            

            SqlCommand addCourse = new SqlCommand("InstAddCourse", conn);
            addCourse.CommandType = CommandType.StoredProcedure;
            addCourse.Parameters.Add(new SqlParameter("@name", name));
            addCourse.Parameters.Add(new SqlParameter("@creditHours", creditHours));
            addCourse.Parameters.Add(new SqlParameter("@price", price));
            addCourse.Parameters.Add(new SqlParameter("@instructorId", Session["user"]));

            conn.Open();
            addCourse.ExecuteNonQuery();
            conn.Close();
            Response.Write("course added successfully");


        }
    }
}