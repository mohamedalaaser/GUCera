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
    public partial class instructorFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int insid = Int16.Parse(instructorId.Text);
            int courseid = Int16.Parse(courseId.Text);

            SqlCommand viewFeedback = new SqlCommand("ViewFeedbacksAddedByStudentsOnMyCourse", conn);
            viewFeedback.CommandType = CommandType.StoredProcedure;
            viewFeedback.Parameters.Add(new SqlParameter("@instrId", insid));
            viewFeedback.Parameters.Add(new SqlParameter("@cid", courseid));
            conn.Open();
            SqlDataReader rdr = viewFeedback.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                Label feedback = new Label();
                feedback.Text =rdr.GetInt32(rdr.GetOrdinal("number"))+ 
                    rdr.GetString(rdr.GetOrdinal("comment")) +
                   rdr.GetInt32(rdr.GetOrdinal("numberOfLikes")) + "<br>";
                form1.Controls.Add(feedback);
            }

        }

        protected void viewAssignments_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int insid = Int16.Parse(instructorId.Text);
            int courseid = Int16.Parse(courseId.Text);

            SqlCommand viewAssignment = new SqlCommand("InstructorViewAssignmentsStudents", conn);
            viewAssignment.CommandType = CommandType.StoredProcedure;
            viewAssignment.Parameters.Add(new SqlParameter("@instrId ", insid));
            viewAssignment.Parameters.Add(new SqlParameter("@cid", courseid));
            conn.Open();
            SqlDataReader rdr = viewAssignment.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                Label assignments = new Label();
                assignments.Text = rdr.GetInt32(rdr.GetOrdinal("sid")) +
                   rdr.GetInt32(rdr.GetOrdinal("cid")) +
                   rdr.GetInt32(rdr.GetOrdinal("assignmentNumber")) +
                    rdr.GetString(rdr.GetOrdinal("assignmenttype")) + "<br>";
                form1.Controls.Add(assignments);
            }

        }

        protected void courseId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}