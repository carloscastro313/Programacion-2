using System;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace SistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        Planeta<Satelite> planeta;
        SateliteDB sateliteDB;
        public FormSistemaSolar()
        {
            InitializeComponent();
            planeta = new Planeta<Satelite>( 20, 20,"Jupiter");
            sateliteDB = new SateliteDB();
           /* try
            {
                planeta.Satelites = sateliteDB.Leer();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            */
        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {
            if(planeta.HiloRotacion==null)
            {
                planeta.AstroEvent += new AstroDelegate(this.MostrarMensaje);
                planeta.HiloRotacion = new Thread(new ThreadStart(planeta.RunEvntRotar));
                planeta.HiloRotacion.Start();
            }
           
        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {
            bool retorno=false;
            foreach (Satelite item in planeta.Satelites)
            {
                if (item.HiloOrbita == null)
                {
                    if (item.InvocarEvento == null)
                    {
                        item.AstroEvent += new AstroDelegate(this.MostrarMensaje);
                    }
                    item.HiloOrbita = new Thread(new ThreadStart(item.RunEvntOrb));
                    item.HiloOrbita.Start();
                    retorno = true;
                }
            }
            if(planeta.Satelites.Count==0|| retorno==false)
            {
                MessageBox.Show("No se puede iniciar la Orbita");
            }
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            try
            {
                Satelite satelite = new Satelite(Convert.ToInt32(this.txOrbita.Text), Convert.ToInt32(this.txRota.Text), this.txNombre.Text);
                if(planeta + satelite)
                {
                   // sateliteDB.Guardar(satelite);
                }   

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }
        public void MostrarMensaje(string mensaje)
        {
            if(this.InvokeRequired)
            {
                MessageBox.Show(mensaje);
            }
            
        }
    }
}
