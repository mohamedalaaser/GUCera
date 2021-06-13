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
    public partial class instructorDefineAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void defineAssignment_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int insid = Int16.Parse(instructorId.Text);
            int courseid = Int16.Parse(courseId.Text);
            int assignmentnumber = Int16.Parse(assignmentNumber.Text);
            string assignmenttype = assignmentType.Text;
            int fullgrade = Int16.Parse(assignmentFullgrade.Text);

            decimal weight = decimal.Parse(assignmentWeight.Text);
         
            string content = assignmentContent.Text;

            SqlCommand define = new SqlCommand("DefineAssignmentOfCourseOfCertianType", conn);
            define.CommandType = CommandType.StoredProcedure;
            define.Parameters.Add(new SqlParameter("@instId", insid));
            define.Parameters.Add(new SqlParameter("@cid", courseid));
            define.Parameters.Add(new SqlParameter("@number", assignmentnumber));
            define.Parameters.Add(new SqlParameter("@type", assignmenttype));
            define.Parameters.Add(new SqlParameter("@fullGrade", fullgrade));
            define.Parameters.Add(new SqlParameter("@weight", weight));
            define.Parameters.Add(new SqlParameter("@deadline", deadline.SelectedDate.ToString()));
            define.Parameters.Add(new SqlParameter("@content", content));

            conn.Open();
            define.ExecuteNonQuery();
            conn.Close();
        }

        }
    }
