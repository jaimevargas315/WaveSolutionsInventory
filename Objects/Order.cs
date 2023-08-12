using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Objects
{
    public class Order
    {
        [PrimaryKey, AutoIncrement]
        public int OrderId { get; set; }
        public int UserID { get; set; }
        public DateTime CreationTime { get; set; }
        public bool Complete { get; set; }
        public DateTime CompletionTime { get; set; }
        public string? Parts { get; set; }
        public string? Products { get; set; }
        public string? MissingParts { get; set; }
        public string? MissingProducts { get; set; }

        public Order() { }

        public Order(int userID, DateTime creationTime, bool complete, DateTime completionTime,
                     string parts, string products, string missingParts, string missingProducts) 
        {
            UserID = userID;
            CreationTime = creationTime;
            Complete = complete;
            CompletionTime = completionTime;
            Parts = parts;
            Products = products;
            MissingParts = missingParts;
            MissingProducts = missingProducts;
        }


    }
}
