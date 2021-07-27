using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GDocumental.DomainModels;
namespace GDocumental
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conta u = new Conta(Global.conexao);
            HttpContext.Current.Session["ContaAtiva"] = u;
            Response.Redirect("/index.aspx");
        }
    }
}