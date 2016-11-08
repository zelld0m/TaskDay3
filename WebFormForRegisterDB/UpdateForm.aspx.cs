using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormForRegisterDB
{
    public partial class UpdateForm : System.Web.UI.Page
    {

        ServiceReferenceRegisterDb.Service1Client svc = new ServiceReferenceRegisterDb.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = svc._VIEWALLFILES();
            GridView1.DataBind();
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            svc.UpdateRegistrationQuery(Tb_LastName.Text, Tb_Fname.Text, Tb_UserName.Text, Tb_Password.Text, Tb_Address.Text, Convert.ToInt32(Tb_IDtoUpdate.Text));
            svc._UpdateAuthority( Tb_AuthorityName.Text, Convert.ToInt32(DropDownList1.SelectedValue), Convert.ToInt32(Tb_IDtoUpdate.Text));
            Page_Load(sender, e);
            ClearControls();
        }

        protected void Btn_Menu_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx", true);
        }

        protected void Btn_Back_Click(object sender, EventArgs e)
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