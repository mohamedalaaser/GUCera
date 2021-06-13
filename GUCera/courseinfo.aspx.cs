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
    public partial class courseinfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            conn.Open();
            // to get the course id
            SqlCommand com = new SqlCommand("Select id from Course where name =@name", conn);
            com.Parameters.AddWithValue("@name", Session["pickedcourse"]);
            int id = Int16.Parse(com.ExecuteScalar().ToString());
            Session["pickedcourseid"] = id;


            // to get the course info
            SqlCommand info = new SqlCommand("courseInformation", conn);
            info.CommandType = System.Data.CommandType.StoredProcedure;
            info.Parameters.Add(new SqlParameter("@id", id));

            
            SqlDataReader rdr = info.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {

                courseid.Text = id+"";

                int credit = rdr.GetInt32(rdr.GetOrdinal("creditHours"));
                ch.Text = credit+"";

                String cname = rdr.GetString(rdr.GetOrdinal("name"));
                cn.Text = cname;

                String cdesc = rdr.GetString(rdr.GetOrdinal("courseDescription"));
                cd.Text = cdesc;

                var price = rdr.GetDecimal(rdr.GetOrdinal("price"));
                p.Text = price+"";

            }
            conn.Close();

            if (!IsPostBack)
            {
                conn.Open();
                // to get the list of instructors
                SqlCommand com2 = new SqlCommand("select U.firstName+ ' ' + U.lastName as 'name',C.insid from InstructorTeachCourse C inner join" +
                    " Users U on U.id=C.insid where C.cid=@cid", conn);
                com2.Parameters.AddWithValue("@cid", id);
                SqlDataAdapter da = new SqlDataAdapter(com2);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DropDownList1.DataSource = ds.Tables[0];
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "insid";
                DropDownList1.DataBind();
                DropDownList1.EnableViewState = true;

                conn.Close();
            }


        }

        protected void enroll_Click(object sender, EventArgs e)
        {

            //Get the information of the connection to the database
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand enroll = new SqlCommand("enrollInCourse", conn);
            enroll.CommandType = CommandType.StoredProcedure;
            enroll.Parameters.Add(new SqlParameter("@sid", Session["user"]));
            enroll.Parameters.Add(new SqlParameter("@cid", Session["pickedcourseid"]));
            enroll.Parameters.Add(new SqlParameter("@instr", DropDownList1.SelectedValue));

            try
            {
                conn.Open();
                enroll.ExecuteNonQuery();
                conn.Close();
                Label1.Text = "Enrolled successfully";
            }
            catch (Exception)
            {
                Label1.Text = "You are already enrolled in this course";
            }
           

          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }
    }
}