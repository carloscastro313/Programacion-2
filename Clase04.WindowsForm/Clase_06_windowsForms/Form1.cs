using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06_windowsForms
{
    public partial class Form1 : Form
    {

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
        }

        private void temperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();

            frm.MdiParent = this;
            
            frm.ShowDialog();
            
            listBox1.Items.Add(frm.miTempera);


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
