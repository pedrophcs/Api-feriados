namespace FeriadosApi.Models
{
    public class Feriado
    {
        public int Id { get; set; }
        public string CodigoIBGE { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime? Data { get; set; }
        public string FeriadoMovel { get; set; }
        
    }
}
