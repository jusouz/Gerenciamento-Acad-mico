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
    internal class ConectaBanco
    {
        MySqlConnection conexão = new MySqlConnection("server=localhost;user id = root;password='chuchublz';database=gerenciamento_academico");
        public string mensagem = "";
        public DataTable listaProfessor()
        {
            MySqlCommand cmd = new MySqlCommand("lista_professor", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            try {
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

        public bool insereProfessor(Professor p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_insereProfessor", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("novoNome", p.nome);
            cmd.Parameters.AddWithValue("salaProf", p.sala);
            cmd.Parameters.AddWithValue("aulasProf", p.numeroAulas);
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

        }//fim insere professor
        public bool excluiProfessor(int cod)
        {
            MySqlCommand cmd = new MySqlCommand("proc_excluiProfessor", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", cod);

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

        }//fim exclui professor
        public bool alteraProfessor(Professor p)
        {
            MySqlCommand cmd = new MySqlCommand("proc_alteraProfessor", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("codigo", p.cod);
            cmd.Parameters.AddWithValue("nomeAlterado", p.nome);
            cmd.Parameters.AddWithValue("salaAlterado", p.sala);
            cmd.Parameters.AddWithValue("numeroAulasAlterado", p.numeroAulas);
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

        }//fim altera professor
        public DataTable listaProva()
        {
            MySqlCommand cmd = new MySqlCommand("lista_prova", conexão);
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
            cmd.Parameters.AddWithValue("nomeP", p.nome);
            cmd.Parameters.AddWithValue("materiaP", p.materia);
            cmd.Parameters.AddWithValue("dataP", p.data);
            cmd.Parameters.AddWithValue("notasP", p.notas);
            cmd.Parameters.AddWithValue("ESTUDANTE_matriculaEstudanteP", p.matriculaEstudante);
            cmd.Parameters.AddWithValue("PROFESSOR_codProfessorP", p.codProfessor);
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
            cmd.Parameters.AddWithValue("codigo", p.cod);
            cmd.Parameters.AddWithValue("nomeAlterado", p.nome);
            cmd.Parameters.AddWithValue("materiaAlterado", p.materia);
            cmd.Parameters.AddWithValue("dataAlterado", p.data);
            cmd.Parameters.AddWithValue("notasAlterado", p.notas);
            cmd.Parameters.AddWithValue("ESTUDANTE_matriculaEstudanteAlterado", p.matriculaEstudante);
            cmd.Parameters.AddWithValue("PROFESSOR_codProfessorAlterado", p.codProfessor);
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
        public bool login(string nome, string senha)
        {
            MySqlCommand cmd = new MySqlCommand("login", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("senha", senha);


            try
            {
                conexão.Open();
                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read()) return true;
                else return false;
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

        }
        public void registrar(string nome, string senha)
        {
            MySqlCommand cmd = new MySqlCommand("registrar", conexão);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("senha", senha);


            try
            {
                conexão.Open();
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;

            }
            finally
            {
                MessageBox.Show("Registrado com sucesso!");
                conexão.Close();
            }

        }
    }
}
