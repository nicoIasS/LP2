using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PFerramenta0030482421016
{
    internal class Fabricante
    {
        public int IdFabricante { get; set; }
        public string NomeFantasia { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daFabricante;
            DataTable dtFabricante = new DataTable();
            try
            {
                daFabricante = new SqlDataAdapter("SELECT * FROM FABRICANTE", frmPrincipal.conexao);
                daFabricante.Fill(dtFabricante);
                daFabricante.FillSchema(dtFabricante, SchemaType.Source);
            }
            catch (Exception ex) { throw ex; }
            return dtFabricante;
        }
        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO FABRICANTE VALUES (@nomefantasia)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@nomefantasia", SqlDbType.VarChar));
                mycommand.Parameters["@nomefantasia"].Value = NomeFantasia;
                retorno = mycommand.ExecuteNonQuery();
            }
            catch(Exception ex) { throw ex; }
            return retorno;
        }
        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE FABRICANTE SET nomeFantasia = @nomeFantasia WHERE id=@idfabricante", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomeFantasia", SqlDbType.VarChar));
                mycommand.Parameters["@idfabricante"].Value = IdFabricante;
                mycommand.Parameters["@nomeFantasia"].Value = NomeFantasia;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }
        public int Excluir()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommnad;
                mycommnad = new SqlCommand("DELETE FROM FABRICANTE WHERE id=@idfabricante", frmPrincipal.conexao);
                mycommnad.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));
                mycommnad.Parameters["@idfabricante"].Value = IdFabricante;
                retorno = mycommnad.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }
    }
}
