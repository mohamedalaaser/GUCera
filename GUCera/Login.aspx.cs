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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
              int  Id = Int16.Parse(username.Text);
                String pass = password.Text;

                SqlCommand loginproc = new SqlCommand("userLogin", conn);
                loginproc.CommandType = CommandType.StoredProcedure;
                loginproc.Parameters.Add(new SqlParameter("@id", Id));
                loginproc.Parameters.Add(new SqlParameter("@password", pass));

                SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Int);
                SqlParameter type = loginproc.Parameters.Add("@type", SqlDbType.Int);
                success.Direction = ParameterDirection.Output;
                type.Direction = ParameterDirection.Output;

                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();

                if (success.Value.ToString() == "1")
                {
                    Session["user"] = Id;

                    if (type.Value.ToString() == "2")  // student
                        Response.Redirect("homepage.aspx");
                    else if (type.Value.ToString() == "0") //instructor
                        Response.Redirect("instructorhomepage.aspx"); // add homepage of instructor here
                    else // admin
                        Response.Redirect("admin.aspx"); //add homepage of admin here


                }
                else
                {
                    Label1.Text = "Incorrect username or password";
                }
            }
            catch(FormatException)
            {
                Label1.Text="Please enter your ID number";

            }
           

           


        }
    }
}