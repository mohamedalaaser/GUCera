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
    public partial class instructorCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void issueCertificate_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
           
            int courseid = Int16.Parse(courseId.Text);
            int studentid = Int16.Parse(studentId.Text);
            int insid = Int16.Parse(instructorId.Text);
        

            SqlCommand issuecertificate = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            issuecertificate.CommandType = CommandType.StoredProcedure;
            issuecertificate.Parameters.Add(new SqlParameter("@cid", courseid));
            issuecertificate.Parameters.Add(new SqlParameter("@sid", studentid));
            issuecertificate.Parameters.Add(new SqlParameter("@insId", insid));
            issuecertificate.Parameters.Add(new SqlParameter("@isuueDate", issueDate.SelectedDate.ToString()));
            conn.Open();
            issuecertificate.ExecuteNonQuery();
            conn.Close();

        }

        protected void issueDate_SelectionChanged(object sender, EventArgs e)
        {

        }
    }



}