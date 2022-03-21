namespace WebApplication1.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BatalhaId { get; set; }  
        public Batalha Batalha { get; set; }
    }
}
