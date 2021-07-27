using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace GDocumental.DomainModels
{
    public class Conta
    {
        public Guid _uidConta { get; set; }
        public string _nome { get; set; }
        public string _email { get; set; }
        public string _senha { get; set; }
        public int _nivel { get; set; }
        public int _estado { get; set; }
        public DateTime _dtRegisto { get; set; }

        private string _ligacao = "";


        public Conta(string conexao)
        {
            _ligacao = conexao;
            _uidConta = Guid.NewGuid();
            _nome = "Convidado";
            _email = "";
            _senha = "";
            _nivel = 0;
            _estado = 1;
            _dtRegisto = DateTime.Now;
        }

        public Boolean criar()
        {
            Boolean estadoOperacao = false;

            try
            {
                SqlConnection con = new SqlConnection(_ligacao);
                SqlCommand comando = new SqlCommand();
                comando.Connection = con;

                comando.CommandType = CommandType.StoredProcedure;


                comando.CommandText = "QConta_Criar";
                comando.Parameters.AddWithValue("@nome", _nome);
                comando.Parameters.AddWithValue("@email", _email);
                comando.Parameters.AddWithValue("@senha", _senha);

                con.Open();
                comando.ExecuteNonQuery();

                con.Close();
                con.Dispose();
                estadoOperacao = true;
            }
            catch
            {
                estadoOperacao = false;
            }
            return estadoOperacao;
        }

        public DataTable listar(int estadoAListar)
        {
            DataTable listaQueVemDaBd = new DataTable();

            SqlDataAdapter blocoNotas = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();
            SqlConnection con = new SqlConnection(_ligacao);
            comando.Connection = con;
            
            comando.CommandType = CommandType.StoredProcedure;
            
            comando.CommandText = "QConta_Listar";
            comando.Parameters.AddWithValue("@estado", estadoAListar);

            blocoNotas.SelectCommand = comando;
            blocoNotas.Fill(listaQueVemDaBd);

            con.Close();
            con.Dispose();

            return listaQueVemDaBd;
        }

        public Conta autenticarUtilizador(string pemail, string psenha)
        {
            Conta c = new Conta(_ligacao);
            DataTable utilizadorValido = new DataTable();

            SqlDataAdapter blocoNotas = new SqlDataAdapter();
            SqlCommand comando = new SqlCommand();
            SqlConnection con = new SqlConnection(_ligacao);
            comando.Connection = con;

            comando.CommandType = CommandType.StoredProcedure;

            comando.CommandText = "QConta_Autenticar";
            comando.Parameters.AddWithValue("@email", pemail);
            comando.Parameters.AddWithValue("@senha", psenha);

            blocoNotas.SelectCommand = comando;
            blocoNotas.Fill(utilizadorValido);

            con.Close();
            con.Dispose();

            if(utilizadorValido.Rows.Count == 1)
            {
                DataRow user = utilizadorValido.Rows[0]; //unica linha
                c._uidConta = Guid.Parse(user["id"].ToString());
                c._nome = "" + user["nome"];
                c._email = "" + user["email"];
                c._nivel = Convert.ToInt32(user["nivel"]);
                c._estado = Convert.ToInt32(user["estado"]);
                c._dtRegisto = Convert.ToDateTime(user["dtRegisto"]);
            }
            return c; //Convidado se nº de rows = 0 ou utilizador se nº rows =1
        }
    }
}