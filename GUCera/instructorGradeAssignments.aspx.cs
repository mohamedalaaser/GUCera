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
    public partial class instructorGradeAssignments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gradeAssignment_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int insid = Int16.Parse(instructorId.Text);
            int studentid = Int16.Parse(studentId.Text);
            int courseid = Int16.Parse(courseId.Text);
            int assignmentnumber = Int16.Parse(assignmentNumber.Text);
            string assignmenttype = assignmentType.Text;
            decimal gradeass= decimal.Parse(grade.Text);

            SqlCommand grading = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            grading.CommandType = CommandType.StoredProcedure;
            grading.Parameters.Add(new SqlParameter("@instrId", insid));
            grading.Parameters.Add(new SqlParameter("@sid", studentid));
            grading.Parameters.Add(new SqlParameter("@cid", courseid));
            grading.Parameters.Add(new SqlParameter("@assignmentNumber", assignmentnumber));
            grading.Parameters.Add(new SqlParameter("@type", assignmenttype));
            grading.Parameters.Add(new SqlParameter("@grade", gradeass));

            conn.Open();
            grading.ExecuteNonQuery();
                conn.Close();
            

        }
    }
}