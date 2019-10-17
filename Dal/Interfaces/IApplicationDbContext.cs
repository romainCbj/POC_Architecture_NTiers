using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Commande> Commande { get; set; }
    }
}
