using Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dal
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Commande> Commande { get; set; }

        public ApplicationDbContext(DbContextOptions option)
            : base(option)
        {

        }
    }
}