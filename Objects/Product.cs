using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Objects
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string? CompanyName { get; set; }
        public string? StorageLocation { get; set; }

        public Product() { }
        public Product(int productId, string name, decimal price,int inStock, int min,
                        int max, string companyName, string storageLocation) 
        {
            ProductID = productId;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;
            StorageLocation = storageLocation;
        }
    }
}
