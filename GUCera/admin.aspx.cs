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
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpromo.aspx");
        }

        protected void ViewCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("admincourses.aspx");
        }
    }
}