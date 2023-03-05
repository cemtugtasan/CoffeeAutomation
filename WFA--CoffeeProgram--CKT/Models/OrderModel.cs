using System.Collections.Generic;

namespace WFA__CoffeeProgram__CKT.Models
{
    public class OrderModel
    {      
        public  Coffee C1 { get; set; } = new Coffee();        
        public  List<Ekstra> Ek1 { get; set; } = new List<Ekstra>();
        public  decimal OrderPrice { get; set; }
    }
}
