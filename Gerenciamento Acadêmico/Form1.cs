using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeEntidade;
using CapaDeNegocio;

namespace Gerenciamento_Acadêmico
{
    public partial class Form1 : Form
    {
        ClasseNegocio clsuser = new ClasseNegocio() ;
        ClasseEntidade clsent = new ClasseEntidade();
        public static string usuario_nome;
        public static string id_tipo;
        public static string usuario_geral;
        public static string usuario_codigo;

        FrmPrincipal f = new FrmPrincipal();
        public Form1()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsuser.usuario = textBox1.Text;
            clsuser.senha = textBox2.Text;
            dt = clsuser.N_Login(clsuser);

        }
    }
}
