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
    public partial class certificates : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand com = new SqlCommand("SELECT C.id, C.name FROM StudentCertifyCourse S inner join Course C on C.id=S.cid WHERE S.sid=@sid", conn);
            com.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            conn.Open();
            SqlDataReader rdr = com.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {

                int courseID = rdr.GetInt32(rdr.GetOrdinal("id"));
                String coursename = rdr.GetString(rdr.GetOrdinal("name")) + "";
                Button course = new Button();
                course.Text = coursename;
                course.ID = courseID+"";
                course.CommandArgument = courseID+"";
                course.Click += (s, a) =>
                {
                    Session["pickedcourse"] = courseID;
                    Response.Redirect("CourseCertificate.aspx");
                };
                certi.Controls.Add(course);


            }
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}