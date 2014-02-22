using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
