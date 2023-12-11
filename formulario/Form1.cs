namespace formulario
{
    public partial class Form1 : Form
    {
        ConectaBanco con = new ConectaBanco();
        public Form1()
        {
            InitializeComponent();
        }
        void listaDGProfessor()
        {
            dgProfessor.DataSource = con.listaProfessor();
            lblMensagem.Text = con.mensagem;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listaDGProfessor();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender,EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.insereProfessor(new Professor(textBox3.Text, int.Parse(textBox1.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text)));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.excluiProfessor(int.Parse(textBox6.Text));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.alteraProfessor(new Professor(textBox5.Text, int.Parse(textBox7.Text), int.Parse(textBox8.Text), int.Parse(textBox9.Text)));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Program.form2.Show();
            Show();
        }
    }
}