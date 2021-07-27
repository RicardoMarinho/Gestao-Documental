using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace GDocumental
{
    public class Documento
    {
        private string _ligacao;
        public Guid _uidDocumento { get; set; }
        public string _titulo { get; set; }
        public string _resumo { get; set; }
        public string _descricao { get; set; }
        public string _autor { get; set; }
        public DateTime _dtPublicacao { get; set; }
        public DateTime _dtRegisto { get; set; }
        public int _estado { get; set; }

        public Documento (string Conexao)
        {
            _ligacao = Conexao;
            _uidDocumento = Guid.NewGuid();
            _titulo = "";
            _resumo = "";
            _descricao = "";
            _autor = "";
            _estado = 1;
            _dtRegisto = DateTime.Now;
            _dtPublicacao = DateTime.Now;
        }

        public DataTable listar(int estadoAListar)
        {
            DataTable listaQueVemDaBd = new DataTable();

            SqlDataAdapter blocoNotas = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();
            SqlConnection con = new SqlConnection(_ligacao);
            comando.Connection = con;

            comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText = "QDocumento_Lista";
            comando.Parameters.AddWithValue("@estado", estadoAListar);

            blocoNotas.SelectCommand = comando;
            blocoNotas.Fill(listaQueVemDaBd);

            con.Close();
            con.Dispose();

            return listaQueVemDaBd;
        }

        public Documento verDoc(string uid, int estado)
        {
            DataTable docValido = new DataTable();
            Documento doc = new Documento(_ligacao);
            SqlDataAdapter blocoNotas = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();
            SqlConnection con = new SqlConnection(_ligacao);
            comando.Connection = con;

            comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText = "QDocumento_Ver";
            comando.Parameters.AddWithValue("@id", uid);
            comando.Parameters.AddWithValue("@estado", estado);

            blocoNotas.SelectCommand = comando;
            blocoNotas.Fill(docValido);

            con.Close();
            con.Dispose();

            if (docValido.Rows.Count == 1)
            {
                DataRow user = docValido.Rows[0]; //unica linha
                doc._uidDocumento = Guid.Parse(user["uidDocumento"].ToString());
                doc._titulo = "" + user["titulo"];
                doc._resumo = "" + user["resumo"];
                doc._descricao = "" + user["descricao"];
                doc._autor = "" + user["autor"];
                doc._estado = Convert.ToInt32(user["estado"]);
                doc._dtRegisto = Convert.ToDateTime(user["dtRegisto"]);
                doc._dtPublicacao = Convert.ToDateTime(user["dtPublicacao"]);
            }

            return doc;
        }

        public DataTable ver(string uid, int estado)
        {
            DataTable listaQueVemDaBd = new DataTable();

            SqlDataAdapter blocoNotas = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();
            SqlConnection con = new SqlConnection(_ligacao);
            comando.Connection = con;

            comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText = "QDocumento_Ver";
            comando.Parameters.AddWithValue("@id", uid);
            comando.Parameters.AddWithValue("@estado", estado);

            blocoNotas.SelectCommand = comando;
            blocoNotas.Fill(listaQueVemDaBd);

            con.Close();
            con.Dispose();

            return listaQueVemDaBd;
        }

    }
}