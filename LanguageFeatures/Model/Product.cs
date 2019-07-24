using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Model
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public string Cartegory { get; set; } = "WaterSports"; //başlangıç degeri her zaman bu atanır. 
        public decimal? Price { get; set; }
        public bool InStock { get; }

        public static Product[] GetProducts()
        {

            Product kayak = new Product
            {
                Name = "Kayak",
                Cartegory = "Water Craft", //category propertisine atanan başlangıç degeri degiştirileblir. 
                Price = 275M

            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };

            return new Product[] { kayak, lifejacket, null };
        }
    }
}
