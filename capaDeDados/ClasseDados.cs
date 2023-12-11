using System.Data;
using System.Data.SqlClient;

namespace capaDeDados
{
    public class ClasseDados
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable Dlogin(ClasseEntidade obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logar", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.user);
            cmd.Parameters.AddWithValue("@senha", obje.passe);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

}
