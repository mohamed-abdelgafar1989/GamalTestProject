using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WorkflowApp
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var remoteAddress = new System.ServiceModel.EndpointAddress("http://localhost:1989/Techno Products/WorkflowEngine/GateWay/Service.svc");
                SR_Service.ServiceClient srv = new SR_Service.ServiceClient(new System.ServiceModel.BasicHttpBinding(), remoteAddress);
                Label1.Text = srv.calc(5, 9).ToString();

                GridView1.DataSource = srv.ShowAllJobTitles().ToList();
                GridView1.DataBind();

            }
        }
    }
}