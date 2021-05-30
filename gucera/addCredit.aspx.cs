using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace gucera
{
    public partial class addCreditCard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            string Name = name.Text;
            string Number = number.Text;
            string Cvv = cvv.Text;
            string Day = day.SelectedValue;
            string Month = month.SelectedValue;
            string Year = year.SelectedValue;
            string date = Day + '/' + Month + '/' + Year;
            DateTime expiry = Convert.ToDateTime(date);
            SqlCommand addCredit = new SqlCommand("addCreditCard" , conn);
            addCredit.CommandType = System.Data.CommandType.StoredProcedure;
            addCredit.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            addCredit.Parameters.Add(new SqlParameter("@number", Number));
            addCredit.Parameters.Add(new SqlParameter("@cardHolderName", Name));
            addCredit.Parameters.Add(new SqlParameter("@cvv", Cvv));
            addCredit.Parameters.Add(new SqlParameter("@expiryDate", date));
            conn.Open();
            addCredit.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Card Added Successfully");
            Response.Redirect("StudentHome.aspx");

        }
    }
}