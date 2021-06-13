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
    public partial class instructorAddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addCourse_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int credithours = Int16.Parse(creditHours.Text);
            string name = courseName.Text;
            decimal Price = decimal.Parse(price.Text);
            int insid = Int16.Parse(instructorId.Text);

            SqlCommand addc = new SqlCommand("InstAddCourse", conn);
            addc.CommandType = CommandType.StoredProcedure;
            addc.Parameters.Add(new SqlParameter("@creditHours", credithours));
            addc.Parameters.Add(new SqlParameter("@name", name));
            addc.Parameters.Add(new SqlParameter("@price", Price));
            addc.Parameters.Add(new SqlParameter("@instructorId", insid));

            conn.Open();
            addc.ExecuteNonQuery();
            conn.Close();
        }
    }
}