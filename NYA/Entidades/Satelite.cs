using System;
using System.Text;
using System.Threading;

namespace Entidades
{
    [Serializable]
    public class Satelite : Astro
    {
        public Satelite() { }

        public Satelite(int duraOrbita, int duraRotacion, string nombre)
            : base(duraOrbita, duraRotacion, nombre) { }

        public string Orbitar()
        {
            return $"Orbitar el satelite: {this.Nombre}";
        }

        public string Rotar()
        {
            return $"Rota el satelite: {this.Nombre}";
        }

        public void RunEvntRotar()
        {
            for (int i = 0; i < this.duracionRotacion; i++)
            {
                Thread.Sleep(800);
            }
            this.InvocarEvento(this.Rotar());
        }

        public void RunEvntOrb()
        {
            for (int i = 0; i < this.duraOrbita; i++)
            {
                Thread.Sleep(400);
            }
            this.InvocarEvento(this.Orbitar());
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Satelite");
            stringBuilder.AppendLine(Mostrar());

            return stringBuilder.ToString();
        }
    }
}
