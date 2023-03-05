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
            Order o1 = new Order();
            o1.MdiParent = this;
            o1.WindowState = FormWindowState.Maximized;
            o1.Show();
            o1.BringToFront();
             
        }

        private void toplamCiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Total t1 = new Total();
            t1.MdiParent = this;
            t1.WindowState = FormWindowState.Maximized;
            t1.Show();
            t1.BringToFront();

        }

        private void ekstrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekstras e1 = new Ekstras();
            e1.MdiParent = this;
            e1.WindowState = FormWindowState.Maximized;
            e1.Show();
            e1.BringToFront();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock s1 = new Stock();
            s1.MdiParent = this;
            s1.WindowState = FormWindowState.Maximized;
            s1.Show();
            s1.BringToFront();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this.ActiveControl != null)
                (this.ActiveControl as Form).Close();
        }


        private void Main_Load(object sender, EventArgs e)
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



        private static Models.Stock AddStockMember(string name, decimal value)
        {
            Models.Stock s1 = new Models.Stock();
            s1.Name = $"{name}";
            s1.Value = value;
            return s1;
        }
    }
}
