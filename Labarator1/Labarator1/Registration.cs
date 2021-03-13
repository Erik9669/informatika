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

    public partial class Registration : Form
    {
        Base Base = new Base();
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(Base Base2)
        {
            InitializeComponent();
            Base = Base2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User user1 in Base.userBindingSource)
            {
                if (user1.Email == textBox1.Text || user1.Login == textBox2.Text)
                { MessageBox.Show("Такой пользователь или почта существует!"); return; }
            }

            User user = new User() { Login = textBox1.Text, Password = textBox2.Text, Name = textBox3.Text, Surname = textBox4.Text, Telephone = textBox5.Text};
            Base.userBindingSource.Add(user);


        }
    }
}
