using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTabling.Core
{
    public class Profesor
    {
        #region Propiedades Privadas

        private string _profesorC;
        private string _profesorD;
        private int _hLunes;
        private int _hMartes;
        private int _hMiercoles;
        private int _hJueves;
        private int _hViernes;

        #endregion

        #region Propiedades Publicas

        public string profesorC
        {
            get { return _profesorC; }
            set { _profesorC = value; }
        }

        public string profesorD
        {
            get { return _profesorD; }
            set { _profesorD = value; }
        }

        public int hLunes
        {
            get { return _hLunes; }
            set { _hLunes = value; }
        }

        public int hMartes
        {
            get { return _hMartes; }
            set { _hMartes = value; }
        }

        public int hMiercoles
        {
            get { return _hMiercoles; }
            set { _hMiercoles = value; }
        }
        
        public int hJueves
        {
            get { return _hJueves; }
            set { _hJueves = value; }
        }
        
        public int hViernes
        {
            get { return _hViernes; }
            set { _hViernes = value; }
        }

        #endregion
    }
}
