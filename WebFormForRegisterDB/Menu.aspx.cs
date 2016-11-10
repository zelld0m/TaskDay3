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
        int AccessLevel; 
        ServiceReferenceRegisterDb.Service1Client svc = new ServiceReferenceRegisterDb.Service1Client();
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Btn_ViewALL_Click(object sender, EventArgs e)
        {
            
            int x=0;
             x= svc._verify(tb_UserName.Text, Tb_Password.Text).Count();

            if (x > 0)
            {
                try
                {
                    AccessLevel = Convert.ToInt32(svc._verify(tb_UserName.Text, Tb_Password.Text).Rows[0][6]); // AccessLevel

                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Congrats PASSWORD AND USERNAME: AccessLevel = " + AccessLevel + " = " + "');", true);
                    Response.Write("<script>alert('Congrats PASSWORD AND USERNAME: AccessLevel = " + AccessLevel + " ');</script>");
                    Response.Redirect("Admin2.aspx?id=" + AccessLevel, true);// Correct 
                }
                catch { ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('ERROR PASSWORD AND USERNAME);", true); }
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('ERROR PASSWORD AND USERNAME);", true);
            }
                AccessLevel = x;
                Page_Load(sender, e);
                ClearControls();
        }
            
           
        protected void Btn_UserOnly(object sender, EventArgs e)
       
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