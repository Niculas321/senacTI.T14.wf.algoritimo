namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário encontrado com sucesso!");
        }

        private void Sacar_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo = saldo - valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }else {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void Depositar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deposito realizado com sucesso!");
        }
    }
}
