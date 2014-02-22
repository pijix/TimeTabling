using System.Collections.Generic;

namespace TimeTabling.Core.Contracts.DAL
{
    public interface IAlumno
    {
        int AddAlumno(Alumno alumno);
        int DeleteAlumno(Alumno alumno);
        int EditAlumno(Alumno alumno);
        List<Alumno> Alumnos();
        Alumno Alumno(string alumnoC);
    }
}
