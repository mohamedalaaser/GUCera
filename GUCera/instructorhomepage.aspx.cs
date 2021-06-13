using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class instructorhomepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("id= " + Session["user"]);
        }

        protected void addCourses_Click(object sender, EventArgs e)
        {
            Response.Redirect("instructorAddCourse.aspx");
        }

        protected void issueCertificate_Click(object sender, EventArgs e)
        {
            Response.Redirect("instructorCertificate.aspx");
        }

        protected void defineAssignment_Click(object sender, EventArgs e)
        {
            Response.Redirect("instructorDefineAssignment.aspx");
        }

        protected void viewFeedbackandAssignments_Click(object sender, EventArgs e)
        {
            Response.Redirect("instructorFeedbackandViewAssignments.aspx");
        }

        protected void gradeAssignment_Click(object sender, EventArgs e)
        {
            Response.Redirect("instructorGradeAssignments.aspx");
        }
    }
}