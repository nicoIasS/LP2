using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace PFerramenta0030482421016
{
    internal class Ferramentas
    {
        public int IdFerramenta { get; set; }
        public string Nome { get; set; }
        public int Fornecedor { get; set; }
        public char Distribuicao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string SiteOficial { get; set; }
        public int IdCategoria { get; set; }
        public int IdFabricante { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daFerramenta;
            DataTable dtFerramenta = new DataTable();
            try
            {
                daFerramenta = new SqlDataAdapter("SELECT * FROM FERRAMENTA", frmPrincipal.conexao);
                daFerramenta.Fill(dtFerramenta);
                daFerramenta.FillSchema(dtFerramenta, SchemaType.Source);
            }
            catch (Exception ex) { throw ex; }
            return dtFerramenta;
        }
        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO FERRAMENTA VALUES (@nome, @distribuicao, @dtcadastro, @siteoficial, @idcategoria, @idfabricante)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar)); 
                mycommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));

                mycommand.Parameters["@nome"].Value = Nome;
                mycommand.Parameters["@distribuicao"].Value = Distribuicao;
                mycommand.Parameters["@dtcadastro"].Value = DtCadastro;
                mycommand.Parameters["@siteoficial"].Value = SiteOficial;
                mycommand.Parameters["@idcategoria"].Value = IdCategoria;
                mycommand.Parameters["@idfabricante"].Value = IdFabricante;

                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE ferramenta SET nome = @nome,"
                    + "distribuicao = @distribuicao,"
                    + "dtcadastro=@dtcadastro, siteoficial=@siteoficial,"
                    + "idcategoria=@idcategoria, idfabricante=@idfabricante "
                    + "WHERE id=@idferramenta", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@distribuicao", SqlDbType.Char));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@siteoficial", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@idfabricante", SqlDbType.Int));
                
                mycommand.Parameters["@idferramenta"].Value = IdFerramenta;
                mycommand.Parameters["@nome"].Value = Nome;
                mycommand.Parameters["@distribuicao"].Value = Distribuicao;
                mycommand.Parameters["@dtcadastro"].Value = DtCadastro;
                mycommand.Parameters["@siteoficial"].Value = SiteOficial;
                mycommand.Parameters["@idcategoria"].Value = IdCategoria;
                mycommand.Parameters["@idfabricante"].Value = IdFabricante;

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
                mycommnad = new SqlCommand("DELETE FROM ferramenta WHERE id=@idferramenta", frmPrincipal.conexao);
                mycommnad.Parameters.Add(new SqlParameter("@idferramenta", SqlDbType.Int));
                mycommnad.Parameters["@idferramenta"].Value = IdFerramenta;
                retorno = mycommnad.ExecuteNonQuery();

            }
            catch (Exception ex) { throw ex; }
            return retorno;
        }



    }
}

