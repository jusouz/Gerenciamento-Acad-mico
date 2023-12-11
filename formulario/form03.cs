using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class form03 : Form
    {
        ConectaBanco con = new ConectaBanco();
        public form03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.login(textBox1.Text, Hash.Hash256(textBox2.Text)))
            {
                Hide();
                Program.form1.Show();
                Show();
            }
            else MessageBox.Show("Login incorreto!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.registrar(textBox3.Text, Hash.Hash256(textBox4.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
