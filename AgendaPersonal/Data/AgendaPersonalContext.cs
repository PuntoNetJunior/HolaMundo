using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgendaPersonal.Models;

namespace AgendaPersonal.Data
{
    public class AgendaPersonalContext : DbContext
    {
        public AgendaPersonalContext (DbContextOptions<AgendaPersonalContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaPersonal.Models.Persona> Persona { get; set; }
    }
}
