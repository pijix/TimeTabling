using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTabling.Core.Contracts.Application
{
    public interface IAula
    {
        int AñadirAula(Aula aula);
        int EliminarAula(string aulaC);
        int ModificarAula(Aula aula);
        List<Aula> Aulas();
        Aula Aula(string aulaC);
    }
}
