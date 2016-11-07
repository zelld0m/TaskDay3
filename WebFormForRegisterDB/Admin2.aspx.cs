using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormForRegisterDB
{
    public partial class Admin2 : System.Web.UI.Page
    {
        ServiceReferenceRegisterDb.Service1Client svc = new ServiceReferenceRegisterDb.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = svc._VIEWALLFILES();
            GridView1.DataBind();
        }

        protected void Btn_UpdateForm_Click(object sender, EventArgs e)
        {
            Server.Transfer("UpdateForm.aspx", true);
        }

        protected void Btn_DeleteForm_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteForm2.aspx", true);
        }

        protected void Btn_ToRegister_Click(object sender, EventArgs e)
        {
            Server.Transfer("RegisterForm.aspx", true);
        }

        protected void Btn_Menu_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}