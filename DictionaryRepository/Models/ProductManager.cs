using DictionaryRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryRepository.Models
{
    public class ProductManager : IRepository
    {
        
        public void Delete(int id)
        {
            Data.ProductList.Remove(id);
        }

        public bool Find(int id)
        {
            if (Data.ProductList.TryGetValue(id, out Product value))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Insert(Product product)
        {
            Data.ProductList.Add(product.Id, product);
        }

        public Dictionary<int, Product> SelectAll()
        {
            return Data.ProductList;
        }

        public Product SelectSingle(int id)
        {
            Product product = Data.ProductList[id];
            return product;
        }

        public void Update(Product product)
        {
            Product updateProduct = Data.ProductList[product.Id];
            updateProduct.Name = product.Name;
            updateProduct.Category = product.Category;
            updateProduct.Price = product.Price;

        }

        public Dictionary<int, Product> GetAllByCategory(string category)
        {
            var result = SelectAll();
            var list = new Dictionary<int, Product>();
            foreach (var item in result)
            {
                if (item.Value.Category == category)
                {
                    list.Add(item.Key, item.Value);
                }
            }
            return list;
        }

    }
}
