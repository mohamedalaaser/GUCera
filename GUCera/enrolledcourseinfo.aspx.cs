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
    public partial class enrolledcourseinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();

            // to get the course info
            SqlCommand info = new SqlCommand("enrollInCourseViewContent", conn);
            info.CommandType = System.Data.CommandType.StoredProcedure;
            info.Parameters.Add(new SqlParameter("@cid", Session["pickedcourseid"]));
            info.Parameters.Add(new SqlParameter("@id", Session["user"]));

            SqlDataReader rdr = info.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                courseid.Text = Session["pickedcourseid"] + "";
                int credit = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                ch.Text = credit + "";
                String cname = rdr.GetString(rdr.GetOrdinal("name"));
                cn.Text = cname;
                String cdesc = rdr.GetString(rdr.GetOrdinal("courseDescription"));
                cd.Text = cdesc;
                var price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                p.Text = price + "";

                String content = rdr.GetString(rdr.GetOrdinal("content"));
                con.Text = content;
            }
            conn.Close();


            conn.Open();

            // to get the assignments of course
            SqlCommand assignments = new SqlCommand("viewAssign", conn);
            assignments.CommandType = System.Data.CommandType.StoredProcedure;
            assignments.Parameters.Add(new SqlParameter("@courseId", Session["pickedcourseid"]));
            assignments.Parameters.Add(new SqlParameter("@Sid", Session["user"]));

            SqlDataReader rdr2 = assignments.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr2.Read())
            {
                Label2.Text = " ";
                String type = rdr2.GetString(rdr2.GetOrdinal("type"));
                int number = rdr2.GetInt32(rdr2.GetOrdinal("number"));
                String assiggnment = type + " " + number;

                Button assb = new Button();
                assb.Text = assiggnment;
                assb.ID = assiggnment;
                assb.CommandArgument = assiggnment;
                assb.Click += (s, a) =>
                {
                    Session["pickedasstype"] = type;
                    Session["pickedassnum"] = number;
                    Response.Redirect("assinfo.aspx");
                };
                Panel1.Controls.Add(assb);
            }




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
    }
