using DictionaryRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictList = new ProductManager();
            var list = dictList.SelectAll();
            Show(list, "All products in original order");
            var mySortedList = list.ToList();


            //Sort mySortedList  pair1 = dictionary, pair2 = dictionary
            mySortedList.Sort((pair1, pair2) => pair1.Value.Name.CompareTo(pair2.Value.Name));
            Show(mySortedList.ToDictionary(pair => pair.Key, pair => pair.Value), "All products sorted by name");


            //Delete record 2
            dictList.Delete(2);
            Show(dictList.SelectAll(), "All products after deleting product with id 2");

            //Add new record
            Product p8 = new Product() 
            { 
                Id = 8, Category = "Computer", Name = "Laptop", Price = 600.00m 
            };
            dictList.Insert(p8);
            Show(dictList.SelectAll(), "All products after adding new product");

            //Update record
            Product p4 = new Product()
            {
                Id = 4,
                Category = "ComputerUpdated",
                Name = "LaptopUpdated",
                Price = 999.00m
            };
            dictList.Update(p4);

            Show(dictList.SelectAll(), "All products after updating product with id 4");

            //select single record
            Product p5 = dictList.SelectSingle(5);
            Console.WriteLine(new string('_', 52));
            Console.WriteLine("Product with id 5 is: " + p5.ToString());
            Console.WriteLine(new string('_', 52));

        }

        private static void Show(Dictionary<int, Product> dictList, string parameter)
        {
            Console.WriteLine(new string('_',52));
            Console.WriteLine(parameter);
            Console.WriteLine(new string('_', 52));

            foreach (var item in dictList)
            {
                Console.WriteLine(item.Key.ToString().PadRight(7) + item.Value.Name.PadRight(30)  + item.Value.Price.ToString().PadLeft(10));
            }
            Console.WriteLine(new string('_', 52));

        }

        
    }
}
