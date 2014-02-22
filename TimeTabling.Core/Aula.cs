using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTabling.Core
{
    public enum TipoAula
    {
       Teorica, Practica
    }

    public class Aula
    {
        #region Propiedades Privadas
        
        private string _aulaC;
        private string _aulaD;
        private TipoAula _tipoAula;
        private bool _softDisponible;
        
        #endregion

        #region Propiedades Publicas
        
        public string aulaC
        {
            get { return _aulaC; }
            set { _aulaC = value; }
        }

        public string aulaD
        {
            get { return _aulaD; }
            set { _aulaD = value; }
        }

        public TipoAula tipoAula
        {
            get { return _tipoAula; }
            set { _tipoAula = value; }
        }

        public bool softDisponible
        {
            get { return _softDisponible; }
            set { _softDisponible = value; }
        }

        #endregion

    }
}
