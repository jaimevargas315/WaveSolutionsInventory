using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Capstone.Service;

namespace Capstone.Objects
{
    public class Outsourced:Part
    {

        public Outsourced() { }
        public  Outsourced(int productId,string name, decimal price, int inStock, int min,
                          int max, string companyName, string storageLocation) 
        {
            /*var outsources = await DatabaseService.GetOutsources();
            bool restart;
            do
            {
                int partId = RandomNumberGenerator.GetInt32(999999999);
                restart = false;
                foreach (Outsourced outsourced in outsources)
                {
                    if(outsourced.PartId == partId)
                    {
                        restart = true;
                        break;
                    }
                }
                PartId = partId;
            } while (restart); */

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
