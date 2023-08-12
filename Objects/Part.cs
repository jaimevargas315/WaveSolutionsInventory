using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Objects
{
    public class Part
    {
        public int PartId { get; set; }
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int MachineID { get; set; }
        public string? CompanyName { get; set; }
        public string? StorageLocation { get; set; }
    }
}
