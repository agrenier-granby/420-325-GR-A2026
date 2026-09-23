using System;
using System.Collections.Generic;

namespace Cours5.Models;

public partial class Adress
{
    public int AdresseId { get; set; }

    public int NoCivique { get; set; }

    public string Rue { get; set; } = null!;

    public int ClientId { get; set; }

    public virtual Client Client { get; set; } = null!;
}
