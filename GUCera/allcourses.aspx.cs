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
    public partial class allcourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand("availableCourses", conn);
            courses.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
           
                String coursename = rdr.GetString(rdr.GetOrdinal("name"));
                Button course = new Button();
                course.Text = coursename;
                course.ID = coursename;
                course.CommandArgument = coursename;
                course.Click += (s, a) => {

                    Session["pickedcourse"] = coursename;
                    Response.Redirect("courseinfo.aspx");
                };
                form1.Controls.Add(course);

           


            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}