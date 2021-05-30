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

namespace GUCera
{
    public partial class CreatePromocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);



            String code = Code.Text;
            DateTime issueDate = DateTime.Parse(IssueDate.Text);
            DateTime expiryDate = DateTime.Parse(ExpiryDate.Text);
            decimal discount = decimal.Parse(Discount.Text);
           

            SqlCommand createPromocode = new SqlCommand("AdminCreatePromocode", conn);
            createPromocode.CommandType = CommandType.StoredProcedure;
            createPromocode.Parameters.Add(new SqlParameter("@code", code));
            createPromocode.Parameters.Add(new SqlParameter("@isuueDate", issueDate));
            createPromocode.Parameters.Add(new SqlParameter("@expiryDate", expiryDate));
            createPromocode.Parameters.Add(new SqlParameter("@discount", discount));
            createPromocode.Parameters.Add(new SqlParameter("@adminId", Session["user"]));


            conn.Open();
            createPromocode.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("promocode created successfully");
            Response.Redirect("AdminHome.aspx");

        }
    }
}