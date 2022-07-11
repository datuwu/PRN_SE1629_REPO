using System;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAcces
{
    public class Program
    {
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConnection = config["ConnectionString:MANH"];
            return strConnection;
        }
        static void ViewMembers()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();
            DbCommand command = factory.CreateCommand();
            if (command == null)
            {
                Console.WriteLine($"Unable to create the command object");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select MemberID,MemberName From FStore";
            using DbDataReader DataReader = command.ExecuteReader();
            Console.WriteLine("-------MemberList-------");
            while (DataReader.Read())
            {
                Console.WriteLine($"MemberID:{DataReader["MemberID"]}," + $"MemberName: {DataReader["MemberName"]}");
            }
        }
        static void Main(string[] args)
        {
            ViewMembers();
            Console.ReadLine();
        }
    }
}