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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            WFA__CoffeeProgram__CKT.Models.Stock s1 = new WFA__CoffeeProgram__CKT.Models.Stock();
            lblMilkValue.Text = Database.StockList[0].Value.ToString();
            lblCoffeeValue.Text = Database.StockList[1].Value.ToString();
            lblCocoaValue.Text = Database.StockList[2].Value.ToString();
            lblAppleSyrupValue.Text = Database.StockList[3].Value.ToString();
            lblVanilleSyrupValue.Text = Database.StockList[4].Value.ToString();
            lblStrawberrySyrupValue.Text = Database.StockList[5].Value.ToString();
            lblPumpkinSyrupValue.Text = Database.StockList[6].Value.ToString();
            lblLemonSyrupValue.Text = Database.StockList[7].Value.ToString();
            lblHazelnutSyrupValue.Text = Database.StockList[8].Value.ToString();
            lblChaiTeaSyrupValue.Text = Database.StockList[9].Value.ToString();
            lblBrownieSyrupValue.Text = Database.StockList[10].Value.ToString();  
        }
    }
}
