using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA__CoffeeProgram__CKT.Models;

namespace WFA__CoffeeProgram__CKT
{
    public partial class Order : Form
    {
        static decimal TotalOrderPrice;
        decimal lastOrderPrice;

        public Order()
        {
            InitializeComponent();
           
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string order = "";           
            order += ProgramContainer.Order.SelectedCoffee.Name + " ";
            foreach (Ekstra ekstra in ProgramContainer.Order.SelectedEkstras)
            {
                order += ekstra.Name + " ";
            }
            order += ProgramContainer.Order.OrderPrice;


            
            lbOrders.Items.Add(order);
            ProgramContainer.OrdersList.Add(order);
            Database.TotalPrice.Add(ProgramContainer.Order.OrderPrice); 
            TotalOrderPrice += ProgramContainer.Order.OrderPrice;           
            ProgramContainer.Order.OrderPrice = 0;
            ProgramContainer.Order.SelectedEkstras.Clear();           
            lblTotalPrice.Text = TotalOrderPrice.ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            lastOrderPrice = Database.TotalPrice[lbOrders.SelectedIndex];
            ProgramContainer.OrdersList.RemoveAt(lbOrders.SelectedIndex);
            Database.TotalPrice.RemoveAt(lbOrders.SelectedIndex);
            lbOrders.Items.RemoveAt(lbOrders.SelectedIndex);                       
            TotalOrderPrice -= lastOrderPrice;
            lblTotalPrice.Text = TotalOrderPrice.ToString();
            
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbOrders.Items.Clear();
            foreach (string item in ProgramContainer.OrdersList)
            {
                Database.AllOrdersText.Add(item);
            }
            ProgramContainer.OrdersList.Clear();
            ProgramContainer.OrderPrice += ProgramContainer.Order.OrderPrice;
            lastOrderPrice = 0;
            lblTotalPrice.Text = lastOrderPrice.ToString();
            ProgramContainer.Order.SelectedEkstras.Clear();
            TotalOrderPrice = 0;
            Database.AllOrders.Add(ProgramContainer.Order);
            SetStock();

        }

        private static void SetStock()
        {
            foreach (OrderModel order in Database.AllOrders)
            {
                if (order.SelectedCoffee.Name == "Black Eye")
                {                   
                    Database.StockList[1].Value -= 3;
                }
                if (order.SelectedCoffee.Name == "Moccha")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 1;
                    Database.StockList[2].Value -= 1;
                }
                if (order.SelectedCoffee.Name == "Flat White")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Cafe Latte")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Dry Cappuccino")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Capuccino")
                {                    
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Latte")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Doppio")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Caramel Mocchiato")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Americano")
                {                    
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Latte Mocchiato")
                {
                    Database.StockList[0].Value -= 1;
                    Database.StockList[1].Value -= 2;
                }
                if (order.SelectedCoffee.Name == "Espresso")
                {                   
                    Database.StockList[1].Value -= 2;
                }
                foreach (Ekstra ekstra in order.SelectedEkstras)
                {
                    if (ekstra.Name =="Apple Syrup")
                    {
                        Database.StockList[3].Value-=0.2m;
                    }
                    if (ekstra.Name == "Vanille Syrup")
                    {
                        Database.StockList[4].Value -= 0.2m;
                    }
                    if (ekstra.Name == "Strawberry Syrup")
                    {
                        Database.StockList[5].Value -= 0.2m;
                    }
                    if (ekstra.Name == "Pumpkin Syrup")
                    {
                        Database.StockList[6].Value -= 0.2m;
                    }
                    if (ekstra.Name == "Lemon Syrup")
                    {
                        Database.StockList[7].Value -= 0.2m;
                    }
                    if (ekstra.Name == "Hazelnut Syrup")
                    {
                        Database.StockList[9].Value -= 0.2m;
                    }
                    if (ekstra.Name == "Brownie Syrup")
                    {
                        Database.StockList[10].Value -= 0.2m;
                    }
                    if (ekstra.Name == "Ekstra Milk")
                    {
                        Database.StockList[0].Value -= 1;
                    }
                    if (ekstra.Name == "Ekstra Shot Coffee")
                    {
                        Database.StockList[1].Value -= 1;
                    }
                }
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            foreach (string order in ProgramContainer.OrdersList)
            {
                lbOrders.Items.Add(order);

            }
            lblTotalPrice.Text = TotalOrderPrice.ToString();
        }
       
    }
}
