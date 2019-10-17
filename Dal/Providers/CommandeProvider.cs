using Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dal.Providers
{
    public class CommandeProvider : ICommandeProvider
    {
        private readonly IApplicationDbContext _context;

        public CommandeProvider(IApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Commande> RecupererToutesLesCommandes()
        {
            return _context.Commande.ToList();
        }
    }
}
