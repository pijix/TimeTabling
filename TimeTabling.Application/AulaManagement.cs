using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTabling.Core;
using TimeTabling.Core.Contracts.Application;
using TimeTabling.DAL;

namespace TimeTabling.Application
{
    public class AulaManagement : IAula
    {
        private readonly AulaDAO _datos;

        public AulaManagement(string conStr)
        {
            _datos = new AulaDAO(conStr);
        }

        public List<Aula> Aulas()
        {
            return _datos.Aulas();
        }

        public Aula Aula(string aulaC)
        {
            return _datos.Aula(aulaC);
        }

        public int AñadirAula(Aula aula)
        {
            return _datos.AddAula(aula);
        }

        public int EliminarAula(string aulaC)
        {
            return _datos.DeleteAula(aulaC);
        }

        public int ModificarAula(Aula aula)
        {
            return _datos.EditAula(aula);
        }
    }
}
