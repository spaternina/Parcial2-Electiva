#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial2_Electiva.Models;

namespace Parcial2_Electiva.Data
{
    public class Parcial2_ElectivaContext : DbContext
    {
        public Parcial2_ElectivaContext (DbContextOptions<Parcial2_ElectivaContext> options)
            : base(options)
        {
        }

        public DbSet<Parcial2_Electiva.Models.Movie> Movie { get; set; }
    }
}
