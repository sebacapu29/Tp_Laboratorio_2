﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario:Persona
    {
        private int _legajo;

        #region Constructor y Sobrecarga
        public Universitario()
        {
            this._legajo = 0;
        }
        public Universitario(int legajo,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this._legajo = legajo;
        }
        #endregion

        #region Metodo Virtual y Abstracto

        protected virtual string MostrarDatos()
        {
            return base.ToString() + "\nLEGAJO NUMERO: " + this._legajo;
        }
        protected abstract string ParticiparEnClase();
        #endregion

        public static bool operator ==(Universitario pg1,Universitario pg2)
        {
            return pg1.Equals(pg2);
        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return (!(pg1 == pg2));
        }
        public override bool Equals(object obj)
        {
            if(obj is Universitario)
                return (this.Nacionalidad == ((Universitario)obj).Nacionalidad && (this.DNI == ((Universitario)obj).DNI || this._legajo == ((Universitario)obj)._legajo));
            else
                return false;
        }
    }
}
