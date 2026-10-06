using System.ComponentModel.DataAnnotations.Schema;

namespace Cours6.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [Column("NomClient")]
        public string Nom {  get; set; }
        public string? Telephone { get; set; }
        public string Courriel { get; set; }
        public int PaysId { get; set; }
        public Pays Pays { get; set; }
    }
}
