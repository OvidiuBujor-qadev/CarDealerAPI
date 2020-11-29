using System;
using System.Linq;

namespace Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            CarDealer.Data.CarDealerDbContext ctx = new CarDealer.Data.CarDealerDbContext();
            var x = ctx.Customers.ToList();
            Console.WriteLine("Hello World!");
        }
    }
}
