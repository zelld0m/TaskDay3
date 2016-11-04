using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormForRegisterDB
{
    public partial class _default : System.Web.UI.Page
    {
        ServiceReferenceRegisterDb.Service1Client svc = new ServiceReferenceRegisterDb.Service1Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ViewALL_Click(object sender, EventArgs e)
        {

            int x = svc.verify(tb_UserName.Text, Tb_Password.Text).Rows.Count;

             ClearControls();
            if (x > 0)
            {

                Server.Transfer("Admin2.aspx", true);
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Congrats PASSWORD AND USERNAME');", true);
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('ERROR PASSWORD AND USERNAME');", true);
            }
            

        }
        




        protected void Btn_UserOnly(object sender, EventArgs e)
        //protected void Btn_Register_Click(object sender, EventArgs e)
        {
            ClearControls();
            Server.Transfer("UserViewForm.aspx", true);
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
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