using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadastroCEP.Models;

namespace CadastroCEP.Data
{
    public class CadastroCEPContext : DbContext
    {
        public CadastroCEPContext (DbContextOptions<CadastroCEPContext> options)
            : base(options)
        {
        }

        public DbSet<CadastroCEP.Models.Cliente> Cliente { get; set; }
    }
}
