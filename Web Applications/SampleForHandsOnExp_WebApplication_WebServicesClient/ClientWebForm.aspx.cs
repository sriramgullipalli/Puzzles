using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleForHandsOnExp_WebApplication_WebServicesClient
{
    public partial class ClientWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            WebServiceClientReference.WebServiceDemoSoapClient WebServiceDemoSoapClient = new WebServiceClientReference.WebServiceDemoSoapClient();
            ResultLabel.Text = WebServiceDemoSoapClient.Add(Convert.ToInt32(FirstNumber.Text), Convert.ToInt32(SecondNumber.Text)).ToString();
        }
    }
}