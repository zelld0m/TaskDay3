using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormForRegisterDB
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        ServiceReferenceRegisterDb.Service1Client svc1 = new ServiceReferenceRegisterDb.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            svc1.insertRegistrationQuery(_Lname.Text, _Fname.Text, _Uname.Text, _Pasword.Text, _Address.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            svc1._InsertAuthority(_Aname.Text, Convert.ToInt32(_Accesslvl.Text));
        }
    }
}