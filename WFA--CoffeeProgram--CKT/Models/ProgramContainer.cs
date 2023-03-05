using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA__CoffeeProgram__CKT.Models
{
    internal class ProgramContainer
    {      
        public static decimal OrderPrice { get; set; }
        public static OrderModel Order { get; set; }
        public static List<string> OrdersList { get; set; } = new List<string>();
    }
}
