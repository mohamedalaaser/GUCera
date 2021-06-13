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
    public partial class assinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            // to get the assignment info
            SqlCommand info = new SqlCommand("SELECT * From Assignment where cid=@cid and number=@number and type=@type", conn);
            info.Parameters.AddWithValue("@cid", Session["pickedcourseid"]);
            info.Parameters.AddWithValue("@number", Session["pickedassnum"]);
            info.Parameters.AddWithValue("@type", Session["pickedasstype"]);


            SqlDataReader rdr = info.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                courseid.Text = Session["pickedcourseid"] + "";
                at.Text = Session["pickedasstype"]+ "";
                an.Text = Session["pickedassnum"]+"";
                var deadline = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                dl.Text = deadline + "";
                var weight = rdr.GetDecimal(rdr.GetOrdinal("weight"));
                w.Text = weight + "";

                int fullgrade = rdr.GetInt32(rdr.GetOrdinal("fullGrade"));
                fg.Text = fullgrade+"";
                String content = rdr.GetString(rdr.GetOrdinal("content"));
                c.Text = content + "";
            }
            conn.Close();

            SqlCommand viewgrade = new SqlCommand("viewAssignGrades", conn);
            viewgrade.CommandType = CommandType.StoredProcedure;
            viewgrade.Parameters.Add(new SqlParameter("@assignType", Session["pickedasstype"]));
            viewgrade.Parameters.Add(new SqlParameter("@assignnumber", Session["pickedassnum"]));
            viewgrade.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            viewgrade.Parameters.Add(new SqlParameter("@cid", Session["pickedcourseid"]));

            SqlParameter grade = viewgrade.Parameters.Add("@assignGrade", SqlDbType.Int);
            grade.Direction = ParameterDirection.Output;

            conn.Open();
            viewgrade.ExecuteNonQuery();
            conn.Close();
            if (grade.Value.ToString() == "")
                gg.Text = "assignment not yet graded or submitted";
            else
            gg.Text = grade.Value.ToString() + "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand submit = new SqlCommand("submitAssign", conn);
            submit.CommandType = CommandType.StoredProcedure;
            submit.Parameters.Add(new SqlParameter("@assignType", Session["pickedasstype"]));
            submit.Parameters.Add(new SqlParameter("@assignnumber", Session["pickedassnum"]));
            submit.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            submit.Parameters.Add(new SqlParameter("@cid", Session["pickedcourseid"]));

            try { 
            conn.Open();
            submit.ExecuteNonQuery();
            conn.Close();
            Label2.Text = "Assignment submitted successfully";
            }
            catch (Exception)
            {
                Label2.Text = "This assignment was already submitted before";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}