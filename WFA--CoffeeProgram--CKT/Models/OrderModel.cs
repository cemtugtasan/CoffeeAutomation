using System.Collections.Generic;

namespace WFA__CoffeeProgram__CKT.Models
{
    public class OrderModel
    {      
        public  Coffee SelectedCoffee { get; set; } = new Coffee();        
        public  List<Ekstra> SelectedEkstras { get; set; } = new List<Ekstra>();
        public  decimal OrderPrice { get; set; }
    }
}
