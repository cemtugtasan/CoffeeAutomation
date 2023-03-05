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
        public decimal lastPrice { get; set; } = 0;
        public Coffees()
        {
            InitializeComponent();
            ProgramContainer.order = new OrderModel();
            foreach (Coffee coffee in Database.Coffees)
            {
                Button b1 = new Button();
                b1.Text = coffee.Name;
                b1.BackgroundImage=Image.FromFile(coffee.ImagePath);
                b1.BackColor = Color.Black;
                b1.ForeColor= Color.White;
                b1.Size = new Size(140, 222);
                flpCoffees.Controls.Add(b1);
            }
        }
        
        public void GetSize(Coffee c1)
        {
            if (rbSmall.Checked)
            {
                c1.Size = SizeType.small;
                
            }
            else if (rbMedium.Checked)
            {
                c1.Size = SizeType.medium;
                c1.Price += 20;
            }
            else if (rbLarge.Checked)
            {
                c1.Size = SizeType.large;
                c1.Price += 40;
            }
        }
        private void Coffees_Load(object sender, EventArgs e)
        {
            lblEmployeeName.Text = Database.Employee.Name;
                
        }
        private void btnBlackEye_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Black Eye";
            c1.Price= 100;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;            
            ProgramContainer.order.C1 = c1;
        }
        private void btnMoccha_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Moccha";
            c1.Price = 120;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnFlatWhite_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Flat White";
            c1.Price = 90;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;

        }

        private void btnCafeLatte_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Cafe Latte";
            c1.Price = 150;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnDryCappuccino_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Dry Cappuccino";
            c1.Price = 75;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnCappuccino_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Capuccino";
            c1.Price = 110;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "latte";
            c1.Price = 67;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
            
        }

        private void btnDoppio_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Doppio";
            c1.Price = 120;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnCaramelMocchiato_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Caramel Mocchiato";
            c1.Price = 150;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnAmericano_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Americano";
            c1.Price = 135;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnLatteMocchiato_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Latte Mocchiato";
            c1.Price = 80;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;
        }

        private void btnEspresso_Click(object sender, EventArgs e)
        {
            Coffee c1 = new Coffee();
            c1.Name = "Espresso";
            c1.Price = 110;
            GetSize(c1);
            ProgramContainer.order.OrderPrice -= lastPrice;
            lastPrice = c1.Price;
            ProgramContainer.order.OrderPrice += c1.Price;
            ProgramContainer.order.C1 = c1;

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    public enum SizeType
    {
        small,
        medium,
        large,
    }
}
