using System;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace ConsoleTester
{
    internal class CosmosDBSQL
    {

        const string EndPoint = "https://cosmossqltest.documents.azure.com:443/";
        const string AuthKey = "==";
        const string DatabaseId = "CustomerDB";
        const string CollectionId = "Customers";

        public async Task<ResourceResponse<Document>> InsertAsync(Models.Customer customer)
        {
            using (var client = new DocumentClient(new Uri(EndPoint), AuthKey))
            {
                var collectionLink = UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId);
                return await client.CreateDocumentAsync(collectionLink, customer);
            }
        }

    }
}
