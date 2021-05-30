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
    public partial class listAllCoursesNonAccepted : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewCoursesNonAccepted = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            viewCoursesNonAccepted.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = viewCoursesNonAccepted.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name = new Label();
                name.Text = "Name: " + courseName + " | ";
                form1.Controls.Add(name);

                int CreditHours = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                Label credithours = new Label();
                credithours.Text = "Credit Hours: " + CreditHours + " | ";
                form1.Controls.Add(credithours);

                decimal Price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                Label price = new Label();
                price.Text = "Price: " + Price + " | ";
                form1.Controls.Add(price);
                String Content;
                if (!rdr.IsDBNull(rdr.GetOrdinal("content")))
                {
                    Content = rdr.GetString(rdr.GetOrdinal("content"));
                }
                else
                {
                    Content = "";
                }

                Label content = new Label();
                content.Text = "Content: " + Content + "<br>  ";
                form1.Controls.Add(content);
                


            }
        }
    }
}