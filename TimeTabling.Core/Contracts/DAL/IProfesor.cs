using System.Collections.Generic;

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
