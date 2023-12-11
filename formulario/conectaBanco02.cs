using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace formulario
{
    internal class conectaBanco02
    {
        MySqlConnection conexão = new MySqlConnection("server=localhost;user id = root;password='';database=gerenciamento_academico");
        public string mensagem = "";
        public DataTable listaProva()
        {
            MySqlCommand cmd = new MySqlCommand("obtem_prova", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexão.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Erro:" + e.Message);
                return null;
            }
            finally
            {
                conexão.Close();
            }
        }
        public bool insereProva(Prova p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereProva", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cod", p.cod);
            cmd.Parameters.AddWithValue("nome", p.nome);
            cmd.Parameters.AddWithValue("materia", p.materia);
            cmd.Parameters.AddWithValue("data", p.data);
            cmd.Parameters.AddWithValue("notas", p.notas);
            try
            {
                conexão.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexão.Close();
            }

        }//fim insere prova
        public bool excluiProva(int cod)
        {
            MySqlCommand cmd = new MySqlCommand("proc_excluiProva", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cod", cod);

            try
            {
                conexão.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexão.Close();
            }

        }//fim exclui prova
        public bool alteraProva(Prova p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraProva", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codAlterado", p.cod);
            cmd.Parameters.AddWithValue("nomeAlterado", p.nome);
            cmd.Parameters.AddWithValue("materiaAlterado", p.materia);
            cmd.Parameters.AddWithValue("dataAlterado", p.data);
            cmd.Parameters.AddWithValue("notasAlterado", p.notas);
            try
            {
                conexão.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexão.Close();
            }

        }//fim altera prova
    }
}

    

