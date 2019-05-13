using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarToolStripButton_Click(object sender, EventArgs e)
        {
            //Forma Facil
            try
            {
                string[] texto = { textBox1.Text, "hola", "Mundo" };
                File.WriteAllLines(@"C:\Users\bueln\Documents\Nueva\Archivo.txt", texto);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message.ToString());
            }
            

        }

        private void AbrirToolStripButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {

                    MessageBox.Show("aqui estoy");
                }
                var archivo = new StreamReader(Dialogo.FileName);
                textBox1.Text = archivo.ReadToEnd();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message.ToString());
                throw;
            }

        }
    }
}
