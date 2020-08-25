using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using DbContext = System.Data.Entity.DbContext;

namespace SynonymService.DataContext
{
    public class SynonymDBContext: DbContext
    {
        public SynonymDBContext(DbContextOptions<SynonymDBContext> options)
            : base(options)
        {
        }
        public DbSet<Models.SynonymModel> Synonyms { get; set; }
    }
}
    