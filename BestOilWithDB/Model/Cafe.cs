using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOilWithDB.Model
{
    public class Cafe
    {
        public int CafeId { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public override string ToString()
        {
            return $"{Price}";
        }
    }
}
