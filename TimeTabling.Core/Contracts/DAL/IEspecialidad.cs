using System.Collections.Generic;

namespace TimeTabling.Core.Contracts.DAL
{
    public interface IEspecialidad
    {
        int AddEspecialidad(Especialidad especialidad);
        int DeleteEspecialidad(Especialidad especialidad);
        int EditEspecialidad(Especialidad especialidad);
        List<Especialidad> Especialidades();
        Especialidad Especialidad(string especialidadC);
    }
}
