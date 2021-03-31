using System;
using static System.Console;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace northwinddb
{
    class Program
    {
        static void Main(string[] args)
        {
            //queryingCategories();
            queryingPrices();
        }

        static void queryingCategories(){
            using (var db = new northwind()){
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
                .Where(product => product.cost > price)
                .OrderByDescending(product => product.cost);

                foreach(product item in prods){
                    Console.WriteLine("{0}: {1} costs{2:$#,##0.00} and has {3} in stock.",
                    item.productID, item.productName, item.cost, item.stock);
                }
            }
        }
    }
}
