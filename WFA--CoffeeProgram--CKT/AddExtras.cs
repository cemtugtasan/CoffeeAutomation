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
    public partial class AddExtras : Form
    {
        public AddExtras()
        {
            InitializeComponent();
        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            string ekstraName = tbExtraName.Text;
            decimal price = decimal.Parse(tbExtraPrice.Text);
            if (string.IsNullOrEmpty(ekstraName))
            {
                MessageBox.Show("Please add to ekstras name");
            }
            if (price<=0)
            {
                MessageBox.Show("Ekstra price can not be 0 or lower than 0");
            }
            Ekstra ekstra = new Ekstra()
            {
                Name=tbExtraName.Text,
                Price=decimal.Parse(tbExtraPrice.Text),
                ImagePath=tbExtraImagePath.Text,
            };
            Database.Ekstras.Add(ekstra);
            tbExtraPrice.Clear();
            tbExtraName.Clear();
            tbExtraImagePath.Clear();

        }

        private void btnSelectPictureExtra_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult dialogResult = fileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                tbExtraImagePath.Text = fileDialog.FileName;
            }
        }
    }
}
