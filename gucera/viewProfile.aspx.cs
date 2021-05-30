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
    public partial class viewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand prof = new SqlCommand("viewMyProfile", conn);
            prof.CommandType = System.Data.CommandType.StoredProcedure;
            prof.Parameters.Add(new SqlParameter("@id", Session["user"]));
            conn.Open();
            SqlDataReader rdr = prof.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String firstName = rdr.GetString(rdr.GetOrdinal("firstName"));
                Label fname = new Label();
                fname.Text = "First Name: " + firstName + " <br> ";
                form1.Controls.Add(fname);
                String lastName = rdr.GetString(rdr.GetOrdinal("lastName"));
                Label lname = new Label();
                lname.Text = "Last Name: " + lastName + " <br> ";
                form1.Controls.Add(lname);
                Int32 id = rdr.GetInt32(rdr.GetOrdinal("id"));
                Label Id = new Label();
                Id.Text = "ID:  " + id.ToString() + " <br> ";
                form1.Controls.Add(Id);
                Decimal gpa= rdr.GetDecimal(rdr.GetOrdinal("gpa"));
                Label Gpa = new Label();
                Gpa.Text = "GPA: " + gpa.ToString() + " <br>  ";
                form1.Controls.Add(Gpa);
                String password = rdr.GetString(rdr.GetOrdinal("password"));
                Label Password = new Label();
                Password.Text ="Password: " +  password + " <br>  ";
                form1.Controls.Add(Password);
                Byte[] gender = (byte[])(rdr.GetSqlBinary(rdr.GetOrdinal("gender")));
                Label Gender = new Label();
                if (gender[0] == 0)
                {
                    Gender.Text = "Gender : Male" + " <br>  ";
                }
                else
                {
                    Gender.Text = "Gender : Female" + " <br>  ";
                }
                form1.Controls.Add(Gender);

                String email = rdr.GetString(rdr.GetOrdinal("email"));
                Label Email = new Label();
                Email.Text = "Email: " + email + " <br>  ";
                form1.Controls.Add(Email);
                String address= rdr.GetString(rdr.GetOrdinal("address"));
                Label Address = new Label();
                Address.Text = "Address: " + address + "   " ;
                form1.Controls.Add(Address);
               







            }




        }
    }
}