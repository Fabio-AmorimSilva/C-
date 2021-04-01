using System;
using static System.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace northwinddb
{
    class Program
    {
        static void Main(string[] args)
        {
            //queryingCategories();
            //queryingPrices();
            //queryingLike();

            if(addProduct(6, "Bob's Burguers", 500M)){
                Console.WriteLine("Product add!");

            }

            listProducts();
        }

        static void queryingCategories(){
            using (var db = new northwind()){
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());
                Console.WriteLine("Categories and how many products they have:");

                // a query to get all categories and their related products
                IQueryable<category> cats = db.categories
                .Include(c => c.products);

                foreach(category c in cats){
                    Console.WriteLine($"{c.categoryName} has {c.products.Count} products.");

                }
            }
        }

        static void queryingPrices(){
            using (var db = new northwind()){
                Console.WriteLine("Products that cost more than a price, highest at top.");

                decimal price;

                Console.WriteLine("Enter a product price: ");
                price = decimal.Parse(Console.ReadLine());

                IQueryable<product> prods = db.products
                .Where(product => product.Cost > price)
                .OrderByDescending(product => product.Cost);

                foreach(product item in prods){
                    Console.WriteLine("{0}: {1} costs{2:$#,##0.00} and has {3} in stock.",
                    item.productID, item.ProductName, item.Cost, item.stock);
                }
            }
        }

        static void queryingLike(){
            using (var db = new northwind()){
                var loggerFactory = db.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(new ConsoleLoggerProvider());

                Console.WriteLine("Enter part of a product name: ");
                string input = Console.ReadLine();

                IQueryable<product> prods = db.products
                .Where(p => EF.Functions.Like(p.ProductName, $"%{input}"));

                foreach(product item in prods){
                    Console.WriteLine("{0} has {1} units in stock. Discontinued? {2}",
                    item.ProductName, item.stock, item.discontinued);
                }

            }
        }

        static bool addProduct(int categoryID, string productName, decimal? price){
            using (var db = new northwind()){
                var newProduct = new product{
                    CategoryID = categoryID,
                    ProductName = productName,
                    Cost = price
                };

                //mark products as add in change tracking
                db.products.Add(newProduct);

                // save tracked change to database
                int affected = db.SaveChanges();
                return(affected == 1);

            }
        }

        static void listProducts(){
            using (var db = new northwind()){
                Console.WriteLine("{0, -3} {1, -35} {2, 8} {3, 5} {4}",
                "ID", "Product Name", "Cost", "Stock", "Disc.");

                foreach(var item in db.products.OrderByDescending(p => p.Cost)){
                    Console.WriteLine("{0:000} {1,-35} {2,8:$#,##0.00} {3,5} {4}", 
                    item.productID, item.ProductName, item.Cost,
                    item.stock, item.discontinued);
                }
            }
        }
    }
}
