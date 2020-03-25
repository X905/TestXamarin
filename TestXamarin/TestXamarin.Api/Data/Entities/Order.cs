using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestXamarin.Api.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int TableNumber { get; set; }
    }
}
