using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TimeTabling.Core.Contracts.DAL
{
    public interface IAula
    {
        int AddAula(Aula aula);
        int DeleteAula(Aula aula);
        int EditAula(Aula aula);
        List<Aula> Aulas();
        Aula Aula(string aulaC);
    }
}
