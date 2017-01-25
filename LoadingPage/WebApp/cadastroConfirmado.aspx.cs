using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoadingPage
{
    public partial class CadastroConfirmado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNome.Text = Session["nome"].ToString();
            txtEmail.Text = Session["email"].ToString();
            txtSenha.Text = Session["senha"].ToString();

            Session.Remove("nome");
            Session.Remove("email");
            Session.Remove("senha");
        }

    }
}



/* Com QueryString
txtNome.Text = Request.QueryString["nome"];
txtEmail.Text = Request.QueryString["email"];
txtSenha.Text = Request.QueryString["senha"];
*/
