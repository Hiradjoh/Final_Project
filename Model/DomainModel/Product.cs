
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModel
{
    public  class Product 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
