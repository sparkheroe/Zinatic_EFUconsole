using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zinatic_EFUweb.Models
{
    public class CaracteristicaModels
    {
        private int idCaracteristica;
        private int numeroOrden;
        private string tituloCaracteristica;
        private string puntaje;
        private string valor;
        

        public int IdCaracteristica
        {
            get { return idCaracteristica; }
            set { idCaracteristica = value; }
        }

        public int NumeroOrden
        {
            get { return numeroOrden; }
            set { numeroOrden = value; }
        }

        public string TituloCaracteristica
        {
            get { return tituloCaracteristica; }
            set { tituloCaracteristica = value; }
        }
        public string Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}