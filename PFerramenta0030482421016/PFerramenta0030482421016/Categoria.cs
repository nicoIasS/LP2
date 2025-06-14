﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PFerramenta0030482421016
{
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descricao { get; set; }

        public DataTable Listar()
        {
            SqlDataAdapter daCategoria;
            DataTable dtCategoria = new DataTable();
            try
            {
                daCategoria = new SqlDataAdapter("SELECT * FROM CATEGORIA", frmPrincipal.conexao);
                daCategoria.Fill(dtCategoria);
                daCategoria.FillSchema(dtCategoria, SchemaType.Source);
            }
            catch (Exception ex) { throw ex; } 
            return dtCategoria;
        }

        public int Salvar ()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CATEGORIA VALUES(@descricao)", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@descricao", SqlDbType.VarChar));
                mycommand.Parameters["@descricao"].Value = Descricao;
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
                mycommand = new SqlCommand("UPDATE CATEGORIA SET descricao =" + "@descricao WHERE id = @idcategoria", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@descricao", SqlDbType.VarChar));
                mycommand.Parameters["@idcategoria"].Value = IdCategoria;
                mycommand.Parameters["@descricao"].Value = Descricao;
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
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM CATEGORIA WHERE id=@idcategoria", frmPrincipal.conexao);
                mycommand.Parameters.Add(new SqlParameter("@idcategoria", SqlDbType.Int));
                mycommand.Parameters["@idcategoria"].Value = IdCategoria;
                retorno = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex) { throw ex; } 
            return retorno;
        }
    }
}
