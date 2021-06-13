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
    public partial class adminaccept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            GridView gridView = new GridView();
            gridView.EmptyDataText = "No records Found";
            gridView.DataSource = cmd.ExecuteReader();
            gridView.DataBind();
            form1.Controls.Add(gridView);
            conn.Close();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void acceptcourse_Click(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            int id = (int)Session["user"];
            int cid = Int16.Parse(CourseID.Text);
            SqlCommand cmd = new SqlCommand("AdminAcceptRejectCourse", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@adminid", id));
            cmd.Parameters.Add(new SqlParameter("@courseId", cid));
            conn.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language=javascript>alert('Course Accepted')</script>");
            conn.Close();
        }
    }
}