using MySql.Data.MySqlClient;

namespace VeW_Games_Tecnologia
{
    public static class Conexao
    {
        private const string Servidor = "localhost";
        private const string Porta = "3306";
        private const string Banco = "vew_jogos_tech";
        private const string Usuario1 = "waudias";
        private const string Usuario2 = "vitor";
        private const string Senha = "SenhaForte123!";

        public static MySqlConnection ObterConexao()
        {
            var connStr1 =
                $"server={Servidor};port={Porta};database={Banco};" +
                $"user={Usuario1};password={Senha};AllowUserVariables=True;";
            var connStr2 =
                $"server={Servidor};port={Porta};database={Banco};" +
                $"user={Usuario2};password={Senha};AllowUserVariables=True;";

            try
            {
                var conexao = new MySqlConnection(connStr1);
                conexao.Open();
                return conexao;
            }
            catch (MySqlException)
            {
                var conexao = new MySqlConnection(connStr2);
                conexao.Open();
                return conexao;
            }
        }
    }
}
