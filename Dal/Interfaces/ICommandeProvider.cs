using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interfaces
{
    public interface ICommandeProvider
    {
        IEnumerable<Commande> RecupererToutesLesCommandes();
    }
}
