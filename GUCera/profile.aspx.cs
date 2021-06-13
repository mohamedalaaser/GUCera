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
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand viewprofile = new SqlCommand("viewMyProfile", conn);
            viewprofile.CommandType = System.Data.CommandType.StoredProcedure;
            viewprofile.Parameters.Add(new SqlParameter("@id", Session["user"]));
            conn.Open();
            SqlDataReader rdr = viewprofile.ExecuteReader(CommandBehavior.CloseConnection);
            
            while (rdr.Read())
            {
                //first name 
                String firstn = rdr.GetString(rdr.GetOrdinal("firstName"));
                fname.Text = firstn;

                //last name 
                String lastn = rdr.GetString(rdr.GetOrdinal("lastName"));
                lname.Text = lastn;

                //email 
                String mail = rdr.GetString(rdr.GetOrdinal("email"));
                email.Text = mail;

                //address
                String add = rdr.GetString(rdr.GetOrdinal("address"));
                address.Text = add;

                //gpa 
                var GG = rdr.GetDecimal(rdr.GetOrdinal("gpa"));
                string gpa = "" + GG;
                Gpa.Text = gpa;

                

            }



        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CreditCard_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand credit = new SqlCommand("addCreditCard",conn);
            credit.CommandType = CommandType.StoredProcedure;
            credit.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            int cardnumber = Int32.Parse(cardnum.Text);
            credit.Parameters.Add(new SqlParameter("@number", cardnumber));
            credit.Parameters.Add(new SqlParameter("@cardHolderName", cardHname.Text));
            int cvv = Int32.Parse(ccv.Text);
            credit.Parameters.Add(new SqlParameter("@cvv", cvv));
            credit.Parameters.Add(new SqlParameter("@expiryDate",Calendar1.SelectedDate.ToString()));
            credit.Connection = conn;


            conn.Open();
            credit.ExecuteNonQuery();
            Response.Write("Credit card added successfully");
            conn.Close();








        }

        protected void NUM_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand Phone = new SqlCommand("addMobile", conn);
            Phone.CommandType = CommandType.StoredProcedure;
            Phone.Parameters.Add(new SqlParameter("@ID", Session["user"]));
            int number = Int32.Parse(PhoneNumber.Text.ToString());
            Phone.Parameters.Add(new SqlParameter("@mobile_number",number));
            Phone.Connection = conn;

            conn.Open();
            Phone.ExecuteNonQuery();
            Response.Write("Phone number added successfully");
            conn.Close();

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand promo = new SqlCommand("viewPromocode",conn);
            promo.CommandType = CommandType.StoredProcedure;
            promo.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            promo.Connection = conn;

            conn.Open();
            GridView gridView = new GridView();
            gridView.EmptyDataText = "no records found";
            gridView.DataSource= promo.ExecuteReader();
            gridView.DataBind();
            myprofile.Controls.Add(gridView);
            conn.Close();






        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}