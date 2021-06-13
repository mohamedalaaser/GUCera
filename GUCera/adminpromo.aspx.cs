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
    public partial class adminpromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void issuestudent_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int student = Int32.Parse(TextBox3.Text);
            cmd.Parameters.Add(new SqlParameter("@sid", student));
            String promo = TextBox4.Text;
            cmd.Parameters.Add(new SqlParameter("@pid", promo));
            cmd.Connection = conn;


            conn.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Promo code sent successfully");
            conn.Close();
        }

        protected void createpromo_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cmd = new SqlCommand("AdminCreatePromocode", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int id = (int)Session["user"];
            cmd.Parameters.Add(new SqlParameter("@adminId", id));
            String code3 = TextBox1.Text;
            cmd.Parameters.Add(new SqlParameter("@code", code3));
            decimal disc = decimal.Parse(TextBox2.Text);
            cmd.Parameters.Add(new SqlParameter("@discount", disc));
            cmd.Parameters.Add(new SqlParameter("@expiryDate", Calendar2.SelectedDate.ToString()));
            cmd.Parameters.Add(new SqlParameter("@isuueDate", Calendar1.SelectedDate.ToString()));
            cmd.Connection = conn;


            conn.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Promo code added successfully");
            conn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}