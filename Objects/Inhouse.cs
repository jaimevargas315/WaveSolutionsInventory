using Capstone.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone.Objects
{
    public class Inhouse:Part
    {
        public Inhouse() { }
        public Inhouse(int productId, string name, decimal price, int inStock, int min,
                  int max, string companyName, string storageLocation)
        {
            /*
            var inhouses = await DatabaseService.GetInhouses();
            bool restart;
            do
            {
                int partId = RandomNumberGenerator.GetInt32(999999999);
                restart = false;
                foreach (Inhouse inhouse in inhouses)
                {
                    if (inhouse.PartId == partId)
                    {
                        restart = true;
                        break;
                    }
                }
                PartId = partId;
            } while (restart);
            */
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
