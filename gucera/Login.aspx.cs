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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int user= Int16.Parse(username.Text);
            string password = pass.Text;
            SqlCommand loginProc = new SqlCommand("userLogin", conn);
            loginProc.CommandType = CommandType.StoredProcedure;
            loginProc.Parameters.Add(new SqlParameter("@id",user));
            loginProc.Parameters.Add(new SqlParameter("@password", password));
            SqlParameter success = loginProc.Parameters.Add("@success", SqlDbType.Int);
            SqlParameter type = loginProc.Parameters.Add("@type", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;
            conn.Open();
            loginProc.ExecuteNonQuery();
            conn.Close();
            Session["user"] = user; 
            if (success.Value.ToString() == "1")
            {
                if (type.Value.ToString() == "0")
                {
                    Response.Redirect("InstructorHome.aspx");
                   
                }
                if (type.Value.ToString() == "2")
                {
                    Response.Redirect("StudentHome.aspx");
                }
                if (type.Value.ToString() == "1")
                {
                    Response.Redirect("AdminHome.aspx");
                }
            }
            else
            {
                string msg = "login Failed, please write your correct credentials OR Register";
                MessageBox.Show(msg);

            }



        }

        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

      
        protected void number_Click(object sender, EventArgs e)
        {
            Response.Redirect("addNumber.aspx");
        }
    }
}