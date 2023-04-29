using PentaGol.Domain.Commons;


namespace PentaGol.Domain.Entites
{
    public class News : Auditable
    {
        public string Title { get; set; }
        public string Description { get; set; } 
        public string ImagePath { get; set; }
    }
}
