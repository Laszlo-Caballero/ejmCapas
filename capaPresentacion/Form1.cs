namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vender vender = new Vender();
            vender.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos(); 
            productos.Show();
        }
    }
}
