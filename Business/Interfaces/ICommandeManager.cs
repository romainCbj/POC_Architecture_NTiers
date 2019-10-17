using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ICommandeManager
    {
        IEnumerable<CommandeBO> RecupererCommandes();
    }
}
