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
    public partial class admincourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("AdminViewAllCourses", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            GridView gridView = new GridView();
            gridView.EmptyDataText = "No records Found";
            gridView.DataSource = cmd.ExecuteReader();
            gridView.DataBind();
            form1.Controls.Add(gridView);
            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminaccept.aspx");
        }
    }
}