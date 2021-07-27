using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GDocumental.DomainModels;

namespace GDocumental
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Documento docs = new Documento(Global.conexao);
            lstDocumentos.DataSource = docs.listar(1);
            lstDocumentos.DataBind();
        }
    }
}