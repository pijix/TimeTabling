using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTabling.Core
{
    public class Especialidad
    {
        #region Propiedad Privada

        private string _especialidadC;
        private string _especialidadD;
        private string _curso;
        private string _asignatura;

        #endregion

        #region Propiedad Publica

        public string especialidadC
        {
            get { return _especialidadC; }
            set { _especialidadC = value; }
        }

        public string especialidadD
        {
            get { return _especialidadD; }
            set { _especialidadD = value; }
        }

        public string curso
        {
            get { return _curso; }
            set { _curso = value; }
        }

        public string asignatura
        {
            get { return _asignatura; }
            set { _asignatura = value; }
        }
     
        #endregion
    }
}
