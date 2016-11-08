using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormForRegisterDB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReferenceRegisterDb.Service1Client svc = new ServiceReferenceRegisterDb.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = svc._VIEWALLFILES();
            GridView1.DataBind();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           //svc._insertPerson(Tb_Lname.Text, Tb_FName.Text, Tb_UserName.Text, Tb_Password.Text, Tb_Address.Text);
            
           //svc._InsertAuthority(Tb_AuthorityName.Text, Convert.ToInt32(DropDownList1.SelectedValue));
           svc.insertRegistrationQuery(Tb_Lname.Text, Tb_FName.Text, Tb_UserName.Text, Tb_Password.Text, Tb_Address.Text);
           
           svc._InsertAuthority(Tb_AuthorityName.Text, DropDownList1.SelectedIndex);
            
           // Page_Load(sender, e);
            ClearControls();
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Server.Transfer("Admin2.aspx", true);
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx", true);
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    

}