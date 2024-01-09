using DictionaryRepository.Models;
using System.Collections.Generic;

namespace DictionaryRepository.Interfaces
{
    public interface IRepository
    {
        Dictionary<int, Product> SelectAll();
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);
        Product SelectSingle(int id);
        bool Find(int id);
        
    }
}
