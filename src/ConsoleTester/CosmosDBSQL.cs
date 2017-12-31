using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace ConsoleTester
{
    internal class CosmosDBSQL
    {

        const string EndPoint = "https://cosmossqltest.documents.azure.com:443/";
        const string AuthKey = "";
        const string DatabaseId = "CustomerDB";
        const string CollectionId = "Customers";

        public async void InsertAsync()
        {
            try
            {
                using (var client = new DocumentClient(new Uri(EndPoint), AuthKey))
                {
                    var customer = new Models.Customer
                    {
                        CustomerId = 1,
                        FirstName = "Jack",
                        LastName = "Smith"
                    };

                    var collectionLink = UriFactory.CreateDocumentCollectionUri(DatabaseId, CollectionId);
                    var asdf = client.CreateDocumentAsync(collectionLink, customer).Result;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
