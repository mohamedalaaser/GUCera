using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class CourseCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand cert = new SqlCommand("select CC.id as 'Course ID', CC.name as 'Course Name',C.sid as 'Student ID',U.firstName+ ' '+ U.lastName as 'Student Name',S.grade as 'Grade', C.issueDate " +
"from StudentCertifyCourse C inner join StudentTakeCourse S on C.cid = S.cid and C.sid = S.sid " +
"inner join Course CC on CC.id = C.cid and CC.id = S.cid " +
"inner join Users as U on U.id = C.sid and U.id = S.sid " +
"where C.sid = @sid and C.cid=@cid", conn);
            cert.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            cert.Parameters.Add(new SqlParameter("@cid", Session["pickedcourse"]));
            conn.Open();
            GridView gridView = new GridView();
            gridView.EmptyDataText = "no records found";
            gridView.DataSource = cert.ExecuteReader();
            gridView.DataBind();
            CourseCert.Controls.Add(gridView);
            conn.Close();




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}