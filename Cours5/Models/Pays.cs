using System;
using System.Collections.Generic;

namespace Cours5.Models;

public partial class Pays
{
    public int PaysId { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
