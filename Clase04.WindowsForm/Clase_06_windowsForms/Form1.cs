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
    public partial class Form1 : Form
    {
        public Paleta paleta;

        public Form1()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
          
            this.WindowState = FormWindowState.Maximized;
            this.groupBox1.Visible = false;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.toolStripMenuItem2.Enabled = false;
            this.paleta = 5;
        }

        private void temperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();
            
            //frm.MdiParent = this;
            
            frm.ShowDialog();
            

            if (frm.DialogResult==DialogResult.OK)
            {
                this.paleta += frm.miTempera;

                for (int i = 0; i < this.paleta.indexMax; i++)
                {
                    this.listBox1.Items.Add((string)this.paleta[i]);
                }
                //listBox1.Items.Add((string)frm.miTempera);
            }

            


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();

            //frm.MdiParent = this;

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.paleta += frm.miTempera;

              for (int i = 0; i < this.paleta.indexMax; i++)
               {
                    this.listBox1.Items.Add((string)this.paleta[i]);
               }
                //listBox1.Items.Add((string)frm.miTempera);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index= listBox1.Items.Count;
            if(index!=0)
            {
                listBox1.Items.RemoveAt(index - 1);
            }
            
        }
    }
}
