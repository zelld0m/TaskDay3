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
            GridView1.DataSource = svc.viewALL();
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
             GridView1.DataSource= svc.AddEntry(Tb_Lname.Text, Tb_FName.Text, Tb_UserName.Text, Tb_Password.Text, Tb_Address.Text, Tb_City.Text,Convert.ToInt16( DropDownList1.SelectedValue));
            //svc.InsertAuthority(Tb_AuthorityName.Text, DropDownList1.TabIndex);

            Page_Load(sender, e);
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

    }

    

}