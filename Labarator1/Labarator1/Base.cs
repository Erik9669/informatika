using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labarator1
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrance newForm = new Entrance(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration(this);
            newForm.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Base_Load(object sender, EventArgs e)
        {
            userBindingSource.Add(new User() {Login = "admin", 
                                              Email = "admin@mail.ru",
                                              Name = "admin",
                                              Surname = "admin",
                                              Telephone = "+7(999)999-99-99",
                                             });
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }
    }
}
