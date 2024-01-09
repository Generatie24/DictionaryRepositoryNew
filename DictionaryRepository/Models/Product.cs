using System;

namespace DictionaryRepository.Models
{
    public class Product:IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Name} {Price} {Category}";
        }
        public string GetNameAndPrice
        {
            get
            {
                return Name + Price.ToString();
            }
        }
        public int CompareTo(Product other)
        {
            //Alphabetical order
            return this.Name.CompareTo(other.Name);
        }
    }
}
