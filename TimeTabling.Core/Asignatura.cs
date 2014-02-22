using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTabling.Core
{
    public class Asignatura
    {
        #region Propiedades Privadas

        private string _asignaturaC;
        private string _asignaturaD;
        private int _horasSemanales;
        private string _patronHorario;
        private string _profesorC;
        private string _aulaC;

        #endregion

        #region Propiedades Publicas

        public string asignaturaC
        {
            get { return _asignaturaC; }
            set { _asignaturaC = value; }
        }

        public string asignaturaD
        {
            get { return _asignaturaD; }
            set { _asignaturaD = value; }
        }

        public int horasSemanales
        {
            get { return _horasSemanales; }
            set { _horasSemanales = value; }
        }

        public string patronHorario
        {
            get { return _patronHorario; }
            set { _patronHorario = value; }
        }
        
        public string profesorC
        {
            get { return _profesorC; }
            set { _profesorC = value; }
        }

        public string aulaC
        {
            get { return _aulaC; }
            set { _aulaC = value; }
        }

        #endregion
    }
}
