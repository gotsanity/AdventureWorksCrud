using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksCrud.Models
{
    class Category
    {
        public string ParentCategory { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }
}
