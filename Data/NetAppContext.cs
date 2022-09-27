using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetApp.Models;

    public class NetAppContext : DbContext
    {
        public NetAppContext (DbContextOptions<NetAppContext> options)
            : base(options)
        {
        }

        public DbSet<NetApp.Models.Produto> Produto { get; set; } = default!;

        public DbSet<NetApp.Models.Categoria> Categoria { get; set; }
    }
