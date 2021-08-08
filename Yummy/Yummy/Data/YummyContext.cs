using System;
using Microsoft.EntityFrameworkCore;
using Yummy.Models;

namespace Yummy.Data
{
    public class YummyContext : DbContext
    {
        public YummyContext(DbContextOptions<YummyContext> options)
             : base(options)
        {
        }

        public DbSet<TblProduct> TblProduct { get; set; }
    }
}
