using Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mapper
{
    public static class CommandeExtension
    {
        public static CommandeBO ToBO(this Commande commande)
        {
            return new CommandeBO
            {
                id = commande.id
            };
        }
    }
}
