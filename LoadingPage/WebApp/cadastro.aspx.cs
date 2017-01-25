using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoadingPage
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void confirmar_Click(object sender, ImageClickEventArgs e)
        {
            Session["nome"] = txtNome.Text;
            Session["email"] = txtEmail.Text;
            Session["senha"] = txtSenha.Text;


            Response.Redirect("cadastroConfirmado.aspx");
        }
    }
}


/* Com QueryString 

    string url;
    url="form2.aspx?nome=" + TextBox1.Text + "&email=" + TextBox2.Text;
    Response.Redirect(url);

 */
