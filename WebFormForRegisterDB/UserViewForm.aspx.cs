using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormForRegisterDB
{
    public partial class UserViewForm : System.Web.UI.Page
    {

        ServiceReferenceRegisterDb.Service1Client svc = new ServiceReferenceRegisterDb.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = svc.UserViewOnly();
            DataBind();
        }

        protected void Btn_MainMenu_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx", true);
        }
    }
}