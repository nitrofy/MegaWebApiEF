using MegaWebApiEF.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaWebApiEF.Infrastructure.DBAccess
{
    public class MegaAppEFDBontext : DbContext
    {
        public MegaAppEFDBontext(DbContextOptions<MegaAppEFDBontext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
