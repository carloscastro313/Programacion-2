using System;

namespace CentralitaPolimorfica_Entidades
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada{ get; }

        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        public float Duracion
        {
            get { return this._duracion; }
        }

        public string NroDestino
        {
            get { return this._nroDestino; }
        }

        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }

        protected virtual string Mostrar()
        {
            return this._duracion + this._nroDestino + this._nroOrigen;
        }

        public static bool operator ==(Llamada a, Llamada b)
        {
            if(a._nroDestino== b._nroDestino&&a._nroOrigen==b._nroOrigen)
            {

                return true;
            }

            return false;
        }

        public static bool operator !=(Llamada a, Llamada b)
        {

            return !(a == b);
        }

        public int OrdenarPorDuracion(Llamada a, Llamada b)
        {
            if (a._duracion > b._duracion)
            {
                return 1;
            }else if(a._duracion < b._duracion)
            {
                return -1;
            }

            return 0;

        }
    }
}
