using ImobiliariaProjeto.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImobiliariaProjeto.Data
{
    public class VendedorContext : DbContext
    {
        public VendedorContext(DbContextOptions<VendedorContext> opt) : base(opt)
        {

        }

        public DbSet<Vendedor> Vendedores { get; set; }
    }
}
