using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA__CoffeeProgram__CKT.Models;

namespace WFA__CoffeeProgram__CKT
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(707, 998);
            Login loginFrm = new Login();
            loginFrm.MdiParent = this;
            loginFrm.WindowState = FormWindowState.Maximized;
            loginFrm.Show();
            loginFrm.BringToFront();
        }

        private void totalTurnoverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coffees coffeeFrm = new Coffees();
            coffeeFrm.MdiParent = this;
            coffeeFrm.WindowState = FormWindowState.Maximized;
            coffeeFrm.Show();
            coffeeFrm.BringToFront();
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order orderFrm = new Order();
            orderFrm.MdiParent = this;
            orderFrm.WindowState = FormWindowState.Maximized;
            orderFrm.Show();
            orderFrm.BringToFront();
             
        }

        private void toplamCiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Total totalFrm = new Total();
            totalFrm.MdiParent = this;
            totalFrm.WindowState = FormWindowState.Maximized;
            totalFrm.Show();
            totalFrm.BringToFront();

        }

        private void ekstrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekstras extraFrm = new Ekstras();
            extraFrm.MdiParent = this;
            extraFrm.WindowState = FormWindowState.Maximized;
            extraFrm.Show();
            extraFrm.BringToFront();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stockFrm = new Stock();
            stockFrm.MdiParent = this;
            stockFrm.WindowState = FormWindowState.Maximized;
            stockFrm.Show();
            stockFrm.BringToFront();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.ActiveControl != null)
                (this.ActiveControl as Form).Close();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            AddEmployees();
            AddStocks();
            AddCoffees();
            AddEkstras();
        }

        private void AddEkstras()
        {
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Brownie Syrup",
                Price = 10,
                ImagePath = "Resources/Brownie Syrup.png"
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Soft",
                Price = 0,
               
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Lactos Free Milk",
                Price = 0,
                
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Cinnemon Syrup",
                Price = 10,
                
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Ekstra Milk",
                Price = 10,
                
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Pumpkin Syrup",
                Price = 10,
                ImagePath = "Resources/Pumpkin pie  syrup.png"
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Vanille Syrup",
                Price = 10,
                ImagePath = "Resources/Vanille Syrup.jpg"
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Ekstra Shot Coffee",
                Price = 10,
               
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Lemon Syrup",
                Price = 10,
                ImagePath = "Resources/Lemon Syrup.jpg"
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Strawberry Syrup",
                Price = 10,
                ImagePath = "Resources/Strawberry syrup.jpg"
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Hazelnut Syrup",
                Price = 10,
                ImagePath = "Resources/hazelnut syrup.png"
            });
            Database.Ekstras.Add(new Ekstra
            {
                Name = "Apple Syrup",
                Price = 10,
                ImagePath = "Resources/Apple syrup.png"
            });
        }

        private void AddCoffees()
        {
            Database.Coffees.Add(new Coffee
            {
                Name = "Black Eye",
                Price = 100,
                ImagePath = "Resources/BlackEye.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Moccha",
                Price = 120,
                ImagePath = "Resources/Moccha.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Flat White",
                Price = 90,
                ImagePath = "Resources/flat white.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Cafe Latte",
                Price = 150,
                ImagePath = "Resources/Cafe latte.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Dry Cappuccino",
                Price = 75,
                ImagePath = "Resources/Cappuchino dry.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Cappuccino",
                Price = 110,
                ImagePath = "Resources/Capiccino.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "latte",
                Price = 67,
                ImagePath = "Resources/Latte.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Doppio",
                Price = 120,
                ImagePath = "Resources/Doppio.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Caramel Mocchiato",
                Price = 150,
                ImagePath = "Resources/CaramelMochiato.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Americano",
                Price = 135,
                ImagePath = "Resources/Amerikano.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Latte Mocchiato",
                Price = 150,
                ImagePath = "Resources/Latte Mochiato.jpg"
            });
            Database.Coffees.Add(new Coffee()
            {
                Name = "Espresso",
                Price = 150,
                ImagePath = "Resources/Espresso.jpg"
            });
        }

        private static void AddStocks()
        {
            Database.StockList.Add(AddStockMember("Milk", 50));
            Database.StockList.Add(AddStockMember("Coffee", 50));
            Database.StockList.Add(AddStockMember("Cocoa", 50));
            Database.StockList.Add(AddStockMember("Apple Syrup", 50));
            Database.StockList.Add(AddStockMember("Vanille Syrup", 50));
            Database.StockList.Add(AddStockMember("Strawberry Syrup", 50));
            Database.StockList.Add(AddStockMember("Pumpkin Pie Syrup", 50));
            Database.StockList.Add(AddStockMember("Lemon Syrup", 50));
            Database.StockList.Add(AddStockMember("Hazelnut Syrup", 50));
            Database.StockList.Add(AddStockMember("ChaiTea Syrup", 50));
            Database.StockList.Add(AddStockMember("Brownie Syrup", 50));
        }

        private static void AddEmployees()
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            e1.Name = "ugur";
            e2.Name = "cemtug";
            e3.Name = "ilknur";
            Database.Employees.Add(e1);
            Database.Employees.Add(e2);
            Database.Employees.Add(e3);
        }

        private static Models.Stock AddStockMember(string name, decimal value)
        {
            Models.Stock stock = new Models.Stock();
            stock.Name = $"{name}";
            stock.Value = value;
            return stock;
        }
    }
}
