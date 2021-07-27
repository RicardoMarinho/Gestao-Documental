using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GDocumental
{
    public partial class login : System.Web.UI.Page
    {
        private anonimo masterPG;

        protected void Page_Load(object sender, EventArgs e)
        {
            masterPG = Page.Master as anonimo;

            if (masterPG.userAtivo == null) masterPG.inicializarUtilizador();

            if (masterPG.userAtivo._nivel > 0) Response.Redirect("/index.aspx");
            else
            {
                if (Page.IsPostBack)
                {
                    #region receber os valores do formulario
                    string pass = HttpContext.Current.Request.Form["txtSenha"];
                    string email = HttpContext.Current.Request.Form["txtEmail"];
                    #endregion
                    masterPG.userAtivo = masterPG.userAtivo.autenticarUtilizador(email, pass);

                    HttpContext.Current.Session["ContaAtiva"] = masterPG.userAtivo;

                    Response.Redirect("/index.aspx");
                }
            }
        }
    }
}