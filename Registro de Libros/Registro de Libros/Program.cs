using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Libros
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Crea una instancia de Form2
            Form2 form2 = new Form2();

            // Crea una instancia de Form1 y pasa Form2 como argumento
            Form1 form1 = new Form1(form2);

            // Asigna la referencia de form1 a form2Instance en Form2
            form2.AsignarForm1Instance(form1);

            // Muestra los formularios
            form2.Show();
            form1.Show();

            Application.Run();
        }
    }
}
