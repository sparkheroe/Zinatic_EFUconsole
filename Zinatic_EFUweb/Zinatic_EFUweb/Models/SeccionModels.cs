using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zinatic_EFUweb.Models
{
    public class SeccionModels
    {
        private int idSeccion;
        private string nombreSeccion;
        private string rango;
        private int numeroColumnas;
        private IEnumerable<CaracteristicaModels> listaCaracteristicas;
        private string valorTotal;
        
        public int IdSeccion
        {
            get { return idSeccion; }
            set { idSeccion = value; }
        }

        public string NombreSeccion
        {
            get { return nombreSeccion; }
            set { nombreSeccion = value; }
        }

        public string Rango
        {
            get { return rango; }
            set { rango = value; }
        }

        public int NumeroColumnas
        {
            get { return numeroColumnas; }
            set { numeroColumnas = value; }
        }

        public IEnumerable<CaracteristicaModels> ListaCaracteristicas
        {
            get { return listaCaracteristicas; }
            set { listaCaracteristicas = value; }
        }

        public string ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
    }
}