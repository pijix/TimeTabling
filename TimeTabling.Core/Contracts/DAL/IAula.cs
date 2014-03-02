using System.Collections.Generic;

namespace TimeTabling.Core.Contracts.DAL
{
    public interface IAula
    {
        int AddAula(Aula aula);
        int DeleteAula(string aulaC);
        int EditAula(Aula aula);
        List<Aula> Aulas();
        Aula Aula(string aulaC);
    }
}
