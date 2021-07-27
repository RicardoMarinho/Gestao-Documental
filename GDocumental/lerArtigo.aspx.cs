using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GDocumental.DomainModels;

namespace GDocumental
{
    public partial class lerArtigo : System.Web.UI.Page
    {
        private anonimo masterPG;
        public Documento docs = new Documento(Global.conexao);
        //public Documento docAberto;

        protected void Page_Load(object sender, EventArgs e)
        {
            masterPG = Page.Master as anonimo;

            if (masterPG.userAtivo == null) masterPG.inicializarUtilizador();

            if (masterPG.userAtivo._nivel < 1) Response.Redirect("/login.aspx");
            else 
            {
                //docAberto = new Documento(Global.conexao);

                docs = docs.verDoc(HttpContext.Current.Request.QueryString["id"], 1);
                //verDoc.DataSource = docs.ver(HttpContext.Current.Request.QueryString["id"],1);
                //verDoc.DataBind();
            }
        }
    }
}