using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTabling.Core
{
    public class Alumno
    {
        #region Propiedades Privadas

        private string _alumnoC;
        private string _alumnoD;

        #endregion  

        #region Propiedades Públicas

        public string alumnoC
        {
            get { return _alumnoC; }
            set { _alumnoC = value; }
        }

        public string alumndoD
        {
            get { return _alumnoD; }
            set { _alumnoD = value; }
        }

        #endregion
    }
}
