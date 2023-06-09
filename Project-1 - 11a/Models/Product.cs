using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1___11a.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DateTime { get; set; }
        public int ProductTypesId { get; set; }
        public ProductType ProductTypes { get; set; }

    }
}
