using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA__CoffeeProgram__CKT.Models
{
    internal static class Database
    {
        public static List<Coffee> Coffees { get; set; }=new List<Coffee>();
        public static List<Ekstra> Ekstras { get; set; }=new List<Ekstra>();
        public static List<Employee> Employees { get; set; } = new List<Employee>();
        public static Employee Employee { get; set; }
        public static List<decimal> TotalPrice { get; set; } = new List<decimal>();
        public static List<OrderModel> AllOrders { get; set; } = new List<OrderModel>();
        public static List<string> AllOrdersText { get; set; } = new List<string>();
        public static List<Stock> StockList { get; set; } = new List<Stock>();



    }
}
