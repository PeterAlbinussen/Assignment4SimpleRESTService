using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4SimpleRESTService.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemQuality { get; set; }
        public int Quantity { get; set; }
    }
}
