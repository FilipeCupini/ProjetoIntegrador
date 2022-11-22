using ImobiliariaProjeto.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiliariaProjeto.Data
{
    public class CorretorContext : DbContext
    {
        public CorretorContext(DbContextOptions<CorretorContext> opt) : base(opt)
        {

        }

        public DbSet<Corretor> Corretores { get; set; }
    }
}
