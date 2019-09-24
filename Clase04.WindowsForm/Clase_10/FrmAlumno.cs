using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;

namespace Clase_10
{
    
    public partial class FrmAlumno : Form
    {
        private Alumno alumno;
        public Alumno MiAlumno
        {
            get { return this.alumno; }
        }
        public FrmAlumno()
        {
            InitializeComponent();

            foreach (ETipoExamen item in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(item);
            }
                     
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                alumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoExamen.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Faltan datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
