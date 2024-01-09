using System.Collections.Generic;

namespace DictionaryRepository.Models
{
    public class Data
    {
        public static Dictionary<int, Product> ProductList { get; set; }
        static Data()
        {
            ProductList = new Dictionary<int, Product>();
            Product p1 = new Product() { Id = 1, Category = "Computer", Name = "Laptop", Price = 600.00m };
            Product p2 = new Product() { Id = 2, Category = "Telephone", Name = "GSM", Price = 400.00m };
            Product p3 = new Product() { Id = 3, Category = "Electronics", Name = "TV", Price = 700.00m };
            Product p4 = new Product() { Id = 4, Category = "Computer", Name = "Laptop", Price = 500.00m };
            Product p5 = new Product() { Id = 5, Category = "Printer", Name = "HP", Price = 650.00m };
            Product p6 = new Product() { Id = 6, Category = "Computer", Name = "Asus", Price = 750.00m };
            Product p7 = new Product() { Id = 7, Category = "Printer", Name = "Helwetia", Price = 850.00m };

            ProductList.Add(p1.Id, p1);
            ProductList.Add(p2.Id, p2);
            ProductList.Add(p3.Id, p3);
            ProductList.Add(p4.Id, p4);
            ProductList.Add(p5.Id, p5);
            ProductList.Add(p6.Id, p6);
            ProductList.Add(p7.Id, p7);
        }
    }
}
