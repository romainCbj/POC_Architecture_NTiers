using Dal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class CommandeBO
    {
        public int id { get; set; }

        public static implicit operator CommandeBO(Commande obj)
        {
            return new CommandeBO
            {
                id = obj.id
            };
        }
    }
}
