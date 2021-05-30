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
    public partial class studentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string firstname = fname.Text;
            string lastname = lname.Text;
            string password = pass.Text;
            string Email = email.Text;
            string Address = address.Text;
            Boolean Gender = bool.Parse(gender.SelectedValue);
            Boolean Type = bool.Parse(type.SelectedValue);
            SqlCommand registerProc;
            if (Type = false)
            {
                registerProc = new SqlCommand("InstructorRegister", conn);
            }
            else
            {
               registerProc = new SqlCommand("studentRegister", conn);

            }
            registerProc.CommandType = CommandType.StoredProcedure;
            registerProc.Parameters.Add(new SqlParameter("@first_name", firstname));
            registerProc.Parameters.Add(new SqlParameter("@password", password));
            registerProc.Parameters.Add(new SqlParameter("@last_name", lastname));
            registerProc.Parameters.Add(new SqlParameter("@email", Email));
            registerProc.Parameters.Add(new SqlParameter("@address", Address));
            registerProc.Parameters.Add(new SqlParameter("@gender", Gender));
            conn.Open();
            registerProc.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("login.aspx");
            Response.Write("Registration successful, You can now log in");



        }
    }
}