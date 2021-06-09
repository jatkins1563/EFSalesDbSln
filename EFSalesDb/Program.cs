using EFSalesDb.Models;
using System;
using System.Linq;

namespace EFSalesDb
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SalesDbContext();

            var customers = context.Customers.ToList();

            var customer = context.Customers.Find(1);

            var cincyCustomers = context.Customers
                .Where(c => c.City == "Cincinnati").ToList();

            //var newCustomer = new Customer()
            //{
            //    Name = "TQL",
            //    City = "Cincinnati",
            //    State = "OH",
            //    Sales = 4000000,
            //    Active = true
            //};
            //context.Customers.Add(newCustomer);
            //var rowsAffected = context.SaveChanges();
            //Console.WriteLine($"{rowsAffected} row(s) affected.");

            //var tql = context.Customers.Find(36);
            //tql.Name = "Total Quality Logistics";
            //var rowsAffected = context.SaveChanges();
            //Console.WriteLine($"{rowsAffected} row(s) affected.");

            //var tql = context.Customers.Find(36);
            //context.Customers.Remove(tql);
            //var rowsAffected = context.SaveChanges();
            //Console.WriteLine($"{rowsAffected} row(s) affected.");

            var orders = context.Orders.ToList();


        }
    }
}