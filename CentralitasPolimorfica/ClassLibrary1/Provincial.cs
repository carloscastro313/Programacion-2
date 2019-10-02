using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaPolimorfica_Entidades
{
    public class Provincial : Llamada
    {
        Franja _franjaHoraria;

        public override float CostoLlamada { get; }

        public Provincial(string origen, float duracion, string destino, Franja miFranja) : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(Llamada unaLlamada, Franja miFranja) : this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, miFranja)
        {

        }

        public bool Equal(Object obj)
        {
            if(obj is Provincial)
            {
                return true;
            }

            return false;
        }

        protected string Mostrar()
        {

            return base.Mostrar() + this._franjaHoraria;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
