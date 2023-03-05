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
    public partial class Ekstras : Form
    {
        public Ekstras()
        {
            InitializeComponent();
            foreach (Ekstra ekstra in Database.Ekstras)
            {
                Button b1 = new Button();
                b1.Text = ekstra.Name;
                b1.BackgroundImage = Image.FromFile(ekstra.ImagePath);
                b1.BackColor = Color.Black;
                b1.ForeColor = Color.White;
                b1.Size = new Size(140, 222);
                flpEkstras.Controls.Add(b1);
            }
        }

        private void btnBrownieSyrup_Click(object sender, EventArgs e)
        {
            Ekstra e1= new Ekstra();
            e1.Name = "Brownie Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnSoftDrinkCoffee_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Soft";            
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnLactosFreeMilk_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Lactos Free Milk";
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnCinnemonSyrup_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Cinnemon Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnEkstraMilk_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Ekstra Milk";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnPumpkin_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Pumpkin Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnVanilleSyrup_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Vanille Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnEkstraShotCoffee_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Ekstra Shot Coffee";
            e1.Price = 20;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnLemonSyrup_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Lemon Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnStrawberrySyrup_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Strawberry Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnHazelnutSyrup_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Hazelnut Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void btnAppleSyrup_Click(object sender, EventArgs e)
        {
            Ekstra e1 = new Ekstra();
            e1.Name = "Apple Syrup";
            e1.Price = 10;
            ProgramContainer.order.OrderPrice += e1.Price;
            ProgramContainer.order.Ek1.Add(e1);
        }

        private void Ekstras_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
