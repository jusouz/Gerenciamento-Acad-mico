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
    public partial class Formulario02 : Form
    {
        ConectaBanco con = new ConectaBanco();
        public Formulario02()
        {
            InitializeComponent();
        }
        void listaDGProva()
        {
            dgProva.DataSource = con.listaProva();
            lblMensagem.Text = con.mensagem;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.insereProva(new Prova(textBox1.Text, 0, textBox3.Text, textBox2.Text, float.Parse(textBox4.Text), textBox12.Text, int.Parse(textBox11.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Program.form1.Show();
            Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.alteraProva(new Prova(textBox7.Text, int.Parse(textBox10.Text), textBox5.Text, textBox9.Text, float.Parse(textBox8.Text), textBox13.Text, int.Parse(textBox14.Text)));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.excluiProva(int.Parse(textBox6.Text));
        }

        private void dgProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Formulario02_Load_1(object sender, EventArgs e)
        {
            listaDGProva();
        }
    }
}
