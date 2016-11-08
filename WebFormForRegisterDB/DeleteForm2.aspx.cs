using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormForRegisterDB
{
    public partial class DeleteForm2 : System.Web.UI.Page
    {

        ServiceReferenceRegisterDb.Service1Client svc = new ServiceReferenceRegisterDb.Service1Client();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = svc._VIEWALLFILES();
            GridView1.DataBind();
        }

        protected void Btn_Delete_Click(object sender, EventArgs e)
        {
            svc.deleteRegisteredPersonQuery(Convert.ToInt32(Tb_Delete.Text));
            svc._DeleteAuthority(Convert.ToInt32(Tb_Delete.Text));
            Page_Load(sender, e);
            ClearControls();
        }

        protected void Btn_Logout_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx", true);
        }

        protected void Btn_AdminForm_Click(object sender, EventArgs e)
        {
            Server.Transfer("Admin2.aspx", true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ClearControls()
        {
            foreach (Control c in Page.Controls)
            {
                foreach (Control ctrl in c.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ((TextBox)ctrl).Text = string.Empty;
                    }
                }
            }
        }
    }
}