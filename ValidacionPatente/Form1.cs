using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionPatente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Asociar el evento KeyPress al TextBox
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string patente = textBox1.Text;

            // Para verificar formato "AANNNAA" o "AAANNN"
            if (patente.Length == 7 && char.IsLetter(patente[0]) && char.IsLetter(patente[1]) && char.IsDigit(patente[2]) &&
                char.IsDigit(patente[3]) && char.IsDigit(patente[4]) && char.IsLetter(patente[5]) && char.IsLetter(patente[6]))
            {
                MessageBox.Show("La patente es válida con formato 'AANNNAA'.", "Éxito");
            }
            else if (patente.Length == 6 && char.IsLetter(patente[0]) && char.IsLetter(patente[1]) && char.IsLetter(patente[2]) &&
                     char.IsDigit(patente[3]) && char.IsDigit(patente[4]) && char.IsDigit(patente[5]))
            {
                MessageBox.Show("La patente es válida con formato 'AAANNN'.", "Éxito");
            }
            else
            {
                MessageBox.Show("Formato de patente inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Para permitir solo letras y numeros en el textbox:
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Solo se permiten letras y números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
