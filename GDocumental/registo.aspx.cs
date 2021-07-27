using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GDocumental.DomainModels;

namespace GDocumental
{
    public partial class registo : System.Web.UI.Page
    {
        private anonimo masterPG;
        protected void Page_Load(object sender, EventArgs e)
        {
            masterPG = Page.Master as anonimo;

            if (masterPG.userAtivo == null) masterPG.inicializarUtilizador();

            if (masterPG.userAtivo._nivel != 0) Response.Redirect("/index.aspx");
            else
            {
                if (Page.IsPostBack)
                {
                    
                }
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string nome = HttpContext.Current.Request.Form["txtNome"];
            string email = HttpContext.Current.Request.Form["txtEmail"];
            string senha = HttpContext.Current.Request.Form["txtEmail"];

            Conta c = new Conta(Global.conexao);
            c._nome = nome;
            c._email = email;
            c._senha = senha;

            c.criar();
            Response.Redirect("/login.aspx");
        }
    }
}