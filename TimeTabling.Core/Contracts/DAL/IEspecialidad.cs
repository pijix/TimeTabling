using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
