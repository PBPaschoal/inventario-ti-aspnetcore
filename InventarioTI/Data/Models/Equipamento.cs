namespace InventarioTI.Data.Models
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAquisicao { get; set; }
    }
}