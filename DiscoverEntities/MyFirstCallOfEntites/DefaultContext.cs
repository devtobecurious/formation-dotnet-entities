using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCallOfEntites
{
    class DefaultContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(local);Database=JeuDontOnEstLeHeros.database.dev;Trusted_Connection=True;");
        }

        public DbSet<Paragraph> Paragraphs { get; set; }
    }
}
