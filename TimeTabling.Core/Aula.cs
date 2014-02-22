namespace TimeTabling.Core
{
    public enum TipoAula
    {
       Teorica, Practica
    }

    public class Aula
    {
        public string AulaC { get; set; }
        public string AulaD { get; set; }
        public TipoAula TipoAula { get; set; }
        public bool SoftDisponible { get; set; }
    }
}
