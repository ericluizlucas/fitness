namespace Fitness.Common.Messages
{
    public static class Database
    {
        public static string ConnectionError => "Erro ao efetuar conexão.";

        public static string ConnectionRedisError => "Erro ao efetuar conexão com REDIS.";
        public static string RegisterNotFound => "Registro não encontrado.";
        public static string SetStringRedisError => "Erro ao gravar chave/valor no REDIS";
        public static string GetStringRedisError => "Erro ao buscar chave/valor no REDIS";


        public static string InsertDatabaseError => "Erro ao gravar registro no banco de dados";
        public static string SelectDatabaseError => "Erro ao buscar registro no banco de dados";
        public static string DeleteDatabaseError => "Erro ao apagar registro no banco de dados";
        public static string UpdateDatabaseError => "Erro ao atualizar registro no banco de dados";

    }
}
