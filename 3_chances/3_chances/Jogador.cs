using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace _3_chances
{
    class Jogador
    {
        Conexao_MySql conexao_MySql = new Conexao_MySql();
        //Declaração atributos
        string Jogador_usu;
        string Pontos_usu;

        public string Jogador_usu1 { get => Jogador_usu; set => Jogador_usu = value; }
        public string Pontos_usu1 { get => Pontos_usu; set => Pontos_usu = value; }

        #region Inserir Dados
        public object Inserir()
        {
            MySqlConnection cn = conexao_MySql.Conexao();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_inserir";
                cmd.Parameters.AddWithValue("@Jogador", Jogador_usu);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Atualizar Dados
        public object Update()
        {
            MySqlConnection cn = conexao_MySql.Conexao();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_update";
                cmd.Parameters.AddWithValue("@PontosJ", Pontos_usu);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Deletar dados
        public object deletar()
        {
            MySqlConnection cn = conexao_MySql.Conexao();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_deletar";
                cmd.Parameters.AddWithValue("@PontosJ", Pontos_usu);
                cmd.Parameters.AddWithValue("@Jogador", Jogador_usu);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {



                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion
    }
}
