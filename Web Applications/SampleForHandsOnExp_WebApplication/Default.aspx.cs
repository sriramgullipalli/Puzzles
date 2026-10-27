using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;

namespace SampleForHandsOnExp_WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnectionString"].ConnectionString.ToString();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Employee where EmployeeId = @Id;", con);
                da.SelectCommand.Parameters.AddWithValue("@Id", InputTextBox.Text);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ResultGridView.DataSource = ds;
                ResultGridView.DataBind();
            }
        }
    }
}