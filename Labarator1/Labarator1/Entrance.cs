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
    public partial class Entrance : Form
    {
        Base BaseMain = new Base();
        public Entrance()
        {
            InitializeComponent();
        }

        public Entrance(Base Base)
        {
            InitializeComponent();
            BaseMain = Base;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           foreach (User user1 in BaseMain.userBindingSource)
            {
                if (user1.Login == textBox1.Text && user1.Password == textBox2.Text)
                { MessageBox.Show("ТЫ авторизован БРАТ!"); return; }
            }
            MessageBox.Show("Авторизация не пройдена!!!");
        }
    }
}
