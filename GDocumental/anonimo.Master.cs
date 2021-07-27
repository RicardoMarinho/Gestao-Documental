using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GDocumental.DomainModels;

namespace GDocumental
{
    public partial class anonimo : System.Web.UI.MasterPage
    {
        public Conta userAtivo;


        public void inicializarUtilizador()
        {
            if(HttpContext.Current.Session["ContaAtiva"] != null)
            {
                //já houve autenticação mesmo sendo como convidado
                userAtivo = (Conta)HttpContext.Current.Session["ContaAtiva"];
            }
            else
            {
                //entrar pela primeira vez no site ainda sem sessão atribuida
                userAtivo = new Conta(Global.conexao);
                HttpContext.Current.Session["ContaAtiva"] = userAtivo;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            //validação de menus
            if (userAtivo == null) inicializarUtilizador();

            if (userAtivo._nivel == 0)
            {
                //acesso anonimo
                menuLogin.Visible = true;
                menuLogout.Visible = false;
                menuRegisto.Visible = true;
            }
            else
            {
                //acesso autenticado
                menuLogin.Visible = false;
                menuLogout.Visible = true;
                menuRegisto.Visible = false;

                if (userAtivo._nivel > 1) itemSA.Visible = true;
            }
        }
    }
}