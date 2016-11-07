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
            //AccessLevel = Convert.ToInt16(svc.VIEWALLFILES().Rows[0][7]);

            
            int x = svc._verify(tb_UserName.Text, Tb_Password.Text).Count;
            
            
            ClearControls();
            if (x > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Congrats PASSWORD AND USERNAME: AccessLevel = " + AccessLevel + " = "  + "');", true);
               
                Response.Write("<script>alert('Congrats PASSWORD AND USERNAME: AccessLevel = " + AccessLevel + " ');</script>");

                Server.Transfer("Admin2.aspx", true);
                }
                else
               {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('ERROR PASSWORD AND USERNAME'"+x+");", true);
                }
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