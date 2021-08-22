using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractMeneger
{
    public class Program
    {
      

        public static void Main(string[] args)
        {
           // CreateHostBuilder(args).Build().Run();


             CustomerDatabase customer1 = new CustomerDatabase { FirsName = "Nikolay", LastName = "Chuchunov", Email = "excwmpel@yandex.ru", Company = "hom", Location = "Russia", Telephone = "89994805555" };

            CustomerService customer = new CustomerService(new ContractMenegerDatabaseContext() ); //CustomerCreate(customer1);

            customer.CustomerCreate(customer1);

            //customer.CustomerReadingList();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


      

      

    }
}
