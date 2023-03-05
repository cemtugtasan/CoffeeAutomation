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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void btnAddExtra_Click(object sender, EventArgs e)
        {
            tbLogin.Text = tbLogin.Text.TrimEnd();
            tbLogin.Text = tbLogin.Text.TrimStart();

            if (tbLogin.Text.Length > 0)
            {
                Main m1 = this.Parent.Parent as Main;
                m1.menuStrip1.Enabled = true;
                foreach (Employee employee in Database.Employees)
                {
                    if (employee.Name == tbLogin.Text)
                    {
                        Database.Employee = employee;
                        ProgramContainer.e1 = employee;
                        this.Close();
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Çalışan Adını Giriniz.");
            }

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
