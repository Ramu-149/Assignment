using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GtihubApp.Models;

    public class EmpContext : DbContext
    {
        public EmpContext (DbContextOptions<EmpContext> options)
            : base(options)
        {
        }

        public DbSet<GtihubApp.Models.Emp> Emp { get; set; }
    }
