using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        ServiceReference1.Service1Client proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                proxy = new ServiceReference1.Service1Client();
                msg.Text = proxy.GetData(11);   
            }
        }

        protected void btnShowMessage_Click(object sender, EventArgs e)
        {
            proxy = new ServiceReference1.Service1Client();
            msg.Text = proxy.GetData(11);
        }
    }
}