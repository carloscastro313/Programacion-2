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
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;
        public List<AlumnoCalificado> alumnos;
          
        public Catedra MiCatreda
        {
            get { return this.catedra; }
        }
   
        public FrmCatedra()
        {
            InitializeComponent();
            catedra = new Catedra();

            foreach (ETipoOrdenamiento item in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrientacion.Items.Add(item);
            }

            this.cmbOrientacion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrientacion.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool suma=false;
            FrmAlumno frmAlumno = new FrmAlumno();
            frmAlumno.ShowDialog();

            if(frmAlumno.DialogResult==DialogResult.OK)
            {
                suma = this.catedra + (Alumno)frmAlumno.MiAlumno;

                Ordenamiento();
            }          
            
            
        }

        private void Ordenamiento()
        {
            if (!object.Equals(this.catedra, null))
            {
                this.lbxAlumnos.Items.Clear();

                switch ((ETipoOrdenamiento)this.cmbOrientacion.SelectedItem)
                {
                    case ETipoOrdenamiento.LegajoAscendente:
                        this.catedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                        break;
                    case ETipoOrdenamiento.LegajoDescendente:
                        this.catedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                        break;
                    case ETipoOrdenamiento.ApellidoAscendente:
                        this.catedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                        break;
                    case ETipoOrdenamiento.ApellidoDescendente:
                        this.catedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                        break;
                }
                foreach (Alumno a in catedra.GetAlumnos)
                {
                    this.lbxAlumnos.Items.Add(Alumno.Mostrar(a));


                }
            }
            
        }

        private void lbxAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOrientacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ordenamiento();
        }
    }
}
