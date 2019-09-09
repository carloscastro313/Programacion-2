using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase4;

namespace Clase04.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entero = int.Parse(this.textBox1.Text);
            string cadena = this.textBox2.Text;
            DateTime fecha = DateTime.Parse(this.textBox3.Text);
          
            Cosa algo = new Cosa();

            algo.EstablecerValor(entero);
            algo.EstablecerValor(fecha);
            algo.EstablecerValor(cadena);

            listBox1.Items.Add(algo.mostrar());
            MessageBox.Show(algo.mostrar());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
