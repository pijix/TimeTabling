using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TimeTabling.Core.Contracts.DAL
{
    public interface IProfesor
    {
        int AddProfesor(Profesor profesor);
        int DeleteProfesor(Profesor profesor);
        int EditProfesor(Profesor profesor);
        List<Profesor> Profesores();
        Profesor Profesor(string profesorC);
    }
}
