﻿using System;
using System.Collections.Generic;
using System.Linq;
using P03_SalesDatabase.Data;
using P03_SalesDatabase.Data.Models;
using P03_SalesDatabase.Data.Seeding;
using P03_SalesDatabase.Data.Seeding.Contracts;
using P03_SalesDatabase.IOManagement;
using P03_SalesDatabase.IOManagement.Contracts;

namespace P03_SalesDatabase
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SalesContext dbContext = new SalesContext();
            //Random random = new Random();
            //IWriter consoleWriter = new ConsoleWriter();

            //ICollection<ISeeder> seeders = new List<ISeeder>();
            //seeders.Add(new ProductSeeder(dbContext, random, consoleWriter));
            //seeders.Add(new StoreSeeder(dbContext, consoleWriter));

            //foreach (var seeder in seeders)
            //{
            //    seeder.Seed();
            //}

            Sale sale = new Sale()
            {
                CustomerId = 1,
                ProductId = 2,
                StoreId = 3
            };

            dbContext
                .Sales
                .Add(sale);

            dbContext.SaveChanges();

            //Sale[] sales = dbContext
            //    .Sales
            //    .ToArray();

            //foreach (var saleInfo in sales)
            //{
            //    Console.WriteLine($"Sale: {saleInfo.SaleId} - {saleInfo.Date}");
            //}
        }
    }
}
