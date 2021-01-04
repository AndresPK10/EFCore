using EFPersistence;
using Microsoft.EntityFrameworkCore;
using System;
using Utilities;

namespace ApplicationOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var opctionbuilder = new DbContextOptionsBuilder<EFContext>();
            opctionbuilder.UseSqlServer(Parameters.ConnectionString);
            var context = new EFContext(opctionbuilder.Options);
            TestConection(context);
        }

        static void TestConection(EFContext context)
        {
            var statusconection = false;
            try
            {
                statusconection = context.Database.EnsureCreated();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            if(statusconection)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Conexion existosa");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error en la conexion");
            }
        }
    }
}
