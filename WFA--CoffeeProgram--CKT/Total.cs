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
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Total_Load(object sender, EventArgs e)
        {
            decimal allOrdersTotalPrice = 0;
            foreach (string item in Database.AllOrdersText)
            {
                lbTotalOrders.Items.Add(item);
                
            }
            lblTotalOrderValue.Text = lbTotalOrders.Items.Count.ToString();
            foreach (decimal item in Database.TotalPrice)
            {
                allOrdersTotalPrice += item;
            }
            lblTotalTurnover.Text = allOrdersTotalPrice.ToString();
        }
    }
}
