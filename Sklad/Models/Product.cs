using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int StorageId { get; set; }
        public Storage Storage { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int Count { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

    }
}
