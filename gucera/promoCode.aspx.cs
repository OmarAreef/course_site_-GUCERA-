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
    public partial class promoCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Gucera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand prof = new SqlCommand("viewPromocode", conn);
            prof.CommandType = System.Data.CommandType.StoredProcedure;
            prof.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            conn.Open();
            SqlDataReader rdr = prof.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                String firstName = rdr.GetString(rdr.GetOrdinal("code"));
                Label fname = new Label();
                fname.Text = "Code: " + firstName + " | ";
                form1.Controls.Add(fname);
                DateTime lastName = rdr.GetDateTime(rdr.GetOrdinal("isuueDate"));
                Label lname = new Label();
                DateTime isDate = Convert.ToDateTime(lastName);
                lname.Text = "issue Date: " + isDate + " | ";
                form1.Controls.Add(lname);
                DateTime expiryDate = rdr.GetDateTime(rdr.GetOrdinal("expiryDate"));
                Label expiry  = new Label();
                DateTime exDate = Convert.ToDateTime(expiryDate);
                expiry.Text = "expiry Date: " + exDate + " | ";
                form1.Controls.Add(expiry);
                Decimal gpa = rdr.GetDecimal(rdr.GetOrdinal("discount"));
                Label Gpa = new Label();
                Gpa.Text = "Discount: " + gpa.ToString() + " | ";
                form1.Controls.Add(Gpa);
                Int32 id = rdr.GetInt32(rdr.GetOrdinal("adminId"));
                Label Id = new Label();
                Id.Text = "Admin ID:  " + id.ToString() + " <br> ";
                form1.Controls.Add(Id);
            }
        }
    }
}