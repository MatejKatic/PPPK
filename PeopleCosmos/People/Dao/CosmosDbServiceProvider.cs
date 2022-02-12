using Microsoft.Azure.Cosmos;
using System.Threading.Tasks;

namespace People.Dao
{
    public static class CosmosDbServiceProvider
    {
        private const string DatabaseName = "Osoba";
        private const string ContainerName = "Osoba";
        private const string Account = "https://osoba.documents.azure.com:443/";
        private const string Key = "yd33J8m49dO9sGQsizljl6uoQ88tJwo8vWf5AUnmE0uvWHCYi9bsvTSx28zZfWm34F5DgMP8IpEbzymizSrVwA==";
        private static ICosmosDbService cosmosDbService;

        public static ICosmosDbService CosmosDbService { get => cosmosDbService; }

        public async static Task Init()
        {
            CosmosClient client = new CosmosClient(Account, Key);
            cosmosDbService = new CosmosDbService(client, DatabaseName, ContainerName);
            DatabaseResponse database = await client.CreateDatabaseIfNotExistsAsync(DatabaseName);
            await database.Database.CreateContainerIfNotExistsAsync(ContainerName, "/id");
        }
    }
}