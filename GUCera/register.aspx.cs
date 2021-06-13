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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signup_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String first = firstname.Text;
            String last = lastname.Text;
            String mail = email.Text;
            String pass = password.Text;
            String add = address.Text;
            int type = Int16.Parse(DropDownList1.SelectedValue);
            //instructor =0 --- student=2
            int gender = Int16.Parse(DropDownList2.SelectedValue);

            if (type == 0) // instructor
            {
                SqlCommand instructorregproc = new SqlCommand("InstructorRegister", conn);
                instructorregproc.CommandType = CommandType.StoredProcedure;
                instructorregproc.Parameters.Add(new SqlParameter("@first_name", first));
                instructorregproc.Parameters.Add(new SqlParameter("@last_name", last));
                instructorregproc.Parameters.Add(new SqlParameter("@password", pass));
                instructorregproc.Parameters.Add(new SqlParameter("@email", mail));
                instructorregproc.Parameters.Add(new SqlParameter("@gender", gender));
                instructorregproc.Parameters.Add(new SqlParameter("@address", add));

                try
                {
                    conn.Open();
                    instructorregproc.ExecuteNonQuery();

                    SqlCommand com = new SqlCommand("Select id from Users where email =@email",conn);
                    com.Parameters.AddWithValue("@email", mail);
                    int id = Int16.Parse(com.ExecuteScalar().ToString());

                    conn.Close();
                    Session["user"] = id;
                    Response.Redirect("instructorhomepage.aspx"); // add instructor homepage here
                }
                catch (Exception)
                {
                    Label1.Text = "This email is already registered";
               
                }
                
            }
            else //student
            {
                SqlCommand studentrregproc = new SqlCommand("studentRegister", conn);
                studentrregproc.CommandType = CommandType.StoredProcedure;
                studentrregproc.Parameters.Add(new SqlParameter("@first_name", first));
                studentrregproc.Parameters.Add(new SqlParameter("@last_name", last));
                studentrregproc.Parameters.Add(new SqlParameter("@password", pass));
                studentrregproc.Parameters.Add(new SqlParameter("@email", mail));
                studentrregproc.Parameters.Add(new SqlParameter("@gender", gender));
                studentrregproc.Parameters.Add(new SqlParameter("@address", add));


                try
                {
                    conn.Open();
                    studentrregproc.ExecuteNonQuery();
                
                    SqlCommand com = new SqlCommand("Select id from Users where email =@email",conn);
                    com.Parameters.AddWithValue("@email", mail);
                    int id = Int16.Parse(com.ExecuteScalar().ToString());
                    conn.Close();
                    Session["user"] = id;

                    
                    
                        Response.Redirect("homepage.aspx");
                   
                   
                

                }
                catch(Exception)
                {

                      Label1.Text = "This email is already registered";
                  
                }




            }

            

        }
    }
}