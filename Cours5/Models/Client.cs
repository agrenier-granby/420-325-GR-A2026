using System;
using System.Collections.Generic;

namespace Cours5.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Courriel { get; set; }

    public int? PaysId { get; set; }

    public virtual ICollection<Adress> Adresses { get; set; } = new List<Adress>();

    public virtual Pays? Pays { get; set; }
}
