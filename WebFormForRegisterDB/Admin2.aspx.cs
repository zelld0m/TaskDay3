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
            _lblAccessLvl.Text = Request.QueryString["id"];
            int accesslvl = Convert.ToInt32(_lblAccessLvl.Text);
            admin_config(accesslvl);
        }

        void admin_config (int accesslvl)
        {
            switch (accesslvl)
            {
                case 1:Btn_DeleteForm.Visible= false ; Btn_ToRegister.Visible = false; Btn_UpdateForm.Visible = false; break;
                case 2:Btn_DeleteForm.Visible = false; Btn_ToRegister.Visible = false; break;
                case 3:Btn_DeleteForm.Visible = false; Btn_UpdateForm.Visible = false; break;
                case 4:Btn_DeleteForm.Visible = false;  break;
                case 5: break;
            }

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