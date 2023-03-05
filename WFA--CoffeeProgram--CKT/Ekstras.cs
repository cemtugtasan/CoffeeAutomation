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
        }

       

        private void Ekstras_Load(object sender, EventArgs e)
        {

            foreach (Ekstra ekstra in Database.Ekstras)
            {
                Button btnEkstra = new Button();
               
                if (ekstra.ImagePath != null)
                {
                    btnEkstra.BackgroundImage = Image.FromFile(ekstra.ImagePath);
                    btnEkstra.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    btnEkstra.Text = ekstra.Name;
                }
                btnEkstra.BackColor = Color.Black;
                btnEkstra.ForeColor = Color.White;
                btnEkstra.Size = new Size(140, 222);
                btnEkstra.Tag = ekstra;
                btnEkstra.Click += BtnEkstra_Click;
                flpEkstras.Controls.Add(btnEkstra);

            }
        }

        private void BtnEkstra_Click(object sender, EventArgs e)
        {
            Ekstra selectedEkstra = (sender as Button).Tag as Ekstra;
            Ekstra orderEkstra = new Ekstra();
            orderEkstra.Name = selectedEkstra.Name;
            orderEkstra.Price= selectedEkstra.Price;

            ProgramContainer.Order.OrderPrice += orderEkstra.Price;
            ProgramContainer.Order.SelectedEkstras.Add(orderEkstra);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
