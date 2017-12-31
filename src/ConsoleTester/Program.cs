using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {

            var cosmosDB = new CosmosDBSQL();

            var tasks = new List<Task>();

            for (int i = 1; i < 6; i++)
            {
                tasks.Add(cosmosDB.InsertAsync(new Models.Customer
                {
                    CustomerId = i,
                    FirstName = "Jack",
                    LastName = "Smith"
                }));
            }

            Task.WaitAll(tasks.ToArray());


        }
    }
}
