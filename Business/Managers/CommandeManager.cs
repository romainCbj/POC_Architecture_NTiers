using Business.Interfaces;
using Business.Mapper;
using Dal;
using Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Managers
{
    public class CommandeManager : ICommandeManager
    {
        private readonly ICommandeProvider _commandeProvider;

        public CommandeManager(ICommandeProvider commandeProvider)
        {
            _commandeProvider = commandeProvider;
        }

        public IEnumerable<CommandeBO> RecupererCommandes()
        {
            var heureOuverture = 14; //glossaire TODO
            var heureFermeture = 22;
            var heure = DateTime.Now.Hour;
            if (heure > heureOuverture && heure < heureFermeture)
            {
                //return _commandeProvider.RecupererToutesLesCommandes().Select(c => c.ToBO()).ToList();
                return _commandeProvider.RecupererToutesLesCommandes().Select(c => (CommandeBO)c).ToList();
            }

            return null;
        }
    }
}
