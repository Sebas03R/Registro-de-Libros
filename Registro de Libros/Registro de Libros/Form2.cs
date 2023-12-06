using System.Windows.Forms;

namespace Registro_de_Libros
{
    public partial class Form2 : Form
    {
        private Form1 form1Instance;
        private Form1 form2Instance;
        public ListBox ListBox1 => listBox1;

        public Form2()
        {
            InitializeComponent();
        }

        public void AsignarForm1Instance(Form1 form1)
        {
            form1Instance = form1;
        }

        public void AgregarElementoListBox1(string elemento)
        {
            listBox1.Items.Add(elemento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (form1Instance != null && form1Instance.ListBox1 != null)
                {
                    form1Instance.ListBox1.Items.Add(listBox1.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Error: form1Instance o ListBox1 es null.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento en listBox1 antes de hacer clic en el botón.");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void EliminarElementoListBox1(object elemento)
        {
            listBox1.Items.Remove(elemento);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem != null)
            {
                ListBox1.Items.Remove(ListBox1.SelectedItem);

                form1Instance.ListBox1.Items.Remove(ListBox1.SelectedItem);

            }
            else
            {
                MessageBox.Show("Selecciona un elemento en ListBox1 antes de hacer clic en el botón.");
            }
        }


    }
}
