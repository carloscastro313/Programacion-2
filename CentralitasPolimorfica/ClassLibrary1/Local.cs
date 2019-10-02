using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaPolimorfica_Entidades
{
    public class Local : Llamada
    {
        private float _costo;

        public override float CostoLlamada{ get;}

        public Local(Llamada unaLlamada, float costo): this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return this._costo * base._duracion;
        }

        public bool equals(object obj)
        {
            if(obj is Local)
            {
                return true;
            }

            return false;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + this._costo;
        }

        public override string ToString()
        {

            return this.Mostrar();
        }

    }
}
