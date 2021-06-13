using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("id= "+ Session["user"]);

        }

        protected void courses_Click(object sender, EventArgs e)
        {

            Response.Redirect("allcourses.aspx");
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

        protected void my_courses_Click(object sender, EventArgs e)
        {
            Response.Redirect("mycourses.aspx");
        }

        protected void my_certificates_Click(object sender, EventArgs e)
        {
            Response.Redirect("certificates.aspx");
        }
    }
}