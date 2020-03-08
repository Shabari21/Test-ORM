using CXO.ProgrammingAssignments.ORM;
using CXO.ProgrammingAssignments.ORM.Interfaces;
using CXO.ProgrammingAssignments.ORM.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace CXO.ProgrammingAssignments.ClientORM
{
    /// <summary>
    /// The calling client class
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var tableName = "User";
            var entity = new EntityModel
            {
                Name = "My Object name",
                Id = new Guid("D6309305-925E-4ED5-9786-6771A79588AF")
            };

            //read from config file
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appConfig.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            //setup our DI
            var serviceProvider = new ServiceCollection();
            serviceProvider.AddSingleton<IDbConnection, DbConnection>(dbConnection => new DbConnection(entity, configuration.GetConnectionString("DefaultConnection")));
            serviceProvider.AddSingleton<IDbContext, DbContext>(dbContext => new DbContext(DbType.Defteros, dbContext.GetService<IDbConnection>()));

            var context = serviceProvider.BuildServiceProvider().GetService<IDbContext>();

            if (context != null)
            {
                Console.WriteLine("Inserting values to table");
                try
                {
                    context.Insert(tableName);
                    Console.WriteLine("Values inserted successfully");

                    entity.Name = "My New Name";
                    Console.WriteLine("Updating table value");
                    context.Update(tableName);
                    Console.WriteLine("Values updated successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error has occured - " + ex.Message);
                }
            }
            else
                Console.WriteLine("The system isn't responding as expected");

            Console.WriteLine("Press Enter key to exit...");
            Console.ReadLine();
        }
    }
}
