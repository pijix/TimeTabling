using System.Collections.Generic;

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
