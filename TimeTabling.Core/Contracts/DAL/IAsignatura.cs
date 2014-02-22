using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TimeTabling.Core.Contracts.DAL
{
    public interface IAsignatura
    {
        int AddAsignatura(Asignatura asignatura);
        int DeleteAsignatura(Asignatura asignatura);
        int EditAsignatura(Asignatura asignatura);
        List<Asignatura> Asignaturas();
        Asignatura Asignatura(string asignaturaC);
    }
}
