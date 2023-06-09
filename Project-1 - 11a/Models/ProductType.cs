using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1___11a.Model
{
    public class ProductType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
