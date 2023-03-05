using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA__CoffeeProgram__CKT.Models
{
    internal class ProgramContainer
    {      
        public static Coffee c1 { get; set; } = new Coffee();
        public static Employee e1 { get; set; } = new Employee();
        public static List<Ekstra> ek1 { get; set; } = new List<Ekstra>();
        public static decimal OrderPrice { get; set; }
        public static OrderModel order { get; set; }
        public static List<string> OrdersList { get; set; } = new List<string>();
    }
}
