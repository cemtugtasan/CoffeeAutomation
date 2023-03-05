using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA__CoffeeProgram__CKT.Models;

namespace WFA__CoffeeProgram__CKT
{
    public partial class Coffees : Form
    {
        public Coffees()
        {
            InitializeComponent();
        }
        
        public void GetSize(Coffee c1)
        {
            if (rbSmall.Checked)
            {
                c1.Size = SizeType.Small;
                
            }
            else if (rbMedium.Checked)
            {
                c1.Size = SizeType.Medium;
                c1.Price += 20;
            }
            else if (rbLarge.Checked)
            {
                c1.Size = SizeType.Large;
                c1.Price += 40;
            }
        }
        private void Coffees_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = Database.Employee.Name;
            ProgramContainer.Order = new OrderModel();
            foreach (Coffee coffee in Database.Coffees)
            {
                Button btnCoffee = new Button();
                btnCoffee.BackgroundImage = Image.FromFile(coffee.ImagePath);
                btnCoffee.BackColor = Color.Black;
                btnCoffee.ForeColor = Color.White;
                btnCoffee.Size = new Size(140, 222);
                btnCoffee.Tag = coffee;
                btnCoffee.Click += BtnCoffee_Click;
                flpCoffees.Controls.Add(btnCoffee);
            }

        }

        private void BtnCoffee_Click(object sender, EventArgs e)
        {
            Coffee selectedCoffee = (sender as Button).Tag as Coffee;

            Coffee orderCoffeee = new Coffee();
            orderCoffeee.Name = selectedCoffee.Name;
            orderCoffeee.Price= selectedCoffee.Price;

            GetSize(orderCoffeee);

            ProgramContainer.Order.OrderPrice = orderCoffeee.Price;            
            ProgramContainer.Order.SelectedCoffee = orderCoffeee;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
