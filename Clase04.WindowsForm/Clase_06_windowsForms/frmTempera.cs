using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_06.Entidades;

namespace Clase_06_windowsForms
{
    public partial class frmTempera : Form
    {
        private Tempera t;

        public Tempera miTempera
        {
            get { return this.t; }
        }


        public frmTempera()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(c);
            }

            this.comboBox1.SelectedItem=ConsoleColor.Magenta;

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marca=this.textBox1.Text;
            int cantidad = int.Parse(this.textBox2.Text);
            ConsoleColor color = (ConsoleColor)this.comboBox1.SelectedItem;

            this.t = new Tempera(cantidad,marca,color);
            
            MessageBox.Show(t);

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
