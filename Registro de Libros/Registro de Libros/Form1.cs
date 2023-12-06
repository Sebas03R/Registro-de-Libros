namespace Registro_de_Libros
{
    public partial class Form1 : Form
    {
        private Form2 form2Instance;
        public ListBox ListBox1 => listBox1;
        public Form1(Form2 form2)
        {
            InitializeComponent();
            form2Instance = form2;
            form2Instance.AsignarForm1Instance(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                string datos = $"{textBox1.Text} - {textBox2.Text} - {textBox3.Text}";

                form2Instance.AgregarElementoListBox1(datos);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos antes de hacer clic en el botón.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
