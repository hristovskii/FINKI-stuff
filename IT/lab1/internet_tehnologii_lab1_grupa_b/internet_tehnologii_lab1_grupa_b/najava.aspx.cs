using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace internet_tehnologii_lab1_grupa_b
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var name = Name.Text;
            var email = Email.Text;
            var password = Password.Text;

            if(name.Length == 0)
            {
                errName.Text = "Vnesete Ime";
                errName.ForeColor = Color.Red;
            }
            if(email.Length == 0)
            {
                errEmail.Text = "Vnesete Email";
                errEmail.ForeColor = Color.Red;
            }
            if(password.Length == 0)
            {
                errPassword.Text = "Vnesete Password";
                errPassword.ForeColor = Color.Red;
            }

            if(name.Length>0 && password.Length>0 && email.Contains("@") && email.Contains(".") ) {
                Session["Email"] = email;
                Response.Redirect("glasaj.aspx");
            }

        }
    }
}