using MySql.Data.MySqlClient;

namespace projeto_teste1
{
    internal class Conexao
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;database=aero;uid=root;pwd=;");

        public MySqlConnection AbrirConexao()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
                conexao.Open();
            return conexao;
        }

        public void FecharConexao()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
                conexao.Close();
        }
    }
    

}
