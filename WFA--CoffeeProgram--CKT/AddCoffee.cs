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
    public partial class AddCoffee : Form
    {
        public AddCoffee()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                tbCoffeeImagePath.Text = fileDialog.FileName;
            }
        }

        private void btnAddCoffee_Click(object sender, EventArgs e)
        {
            string coffeeName = tbCoffeeName.Text;
            decimal price = decimal.Parse(tbCoffeePrice.Text);

            if (string.IsNullOrEmpty(coffeeName))
            {
                MessageBox.Show("Please add to coffee name");
            }
            if (price<=0)
            {
                MessageBox.Show("Coffee price can not be 0 or lower than 0");
            }
            Coffee coffee = new Coffee()
            {
                Name= coffeeName,
                Price= price,
                ImagePath= tbCoffeeImagePath.Text,
            };
            Database.Coffees.Add(coffee);
            tbCoffeeImagePath.Clear();
            tbCoffeeName.Clear();
            tbCoffeePrice.Clear();
        }

        private void AddCoffee_Load(object sender, EventArgs e)
        {

        }
    }
}
