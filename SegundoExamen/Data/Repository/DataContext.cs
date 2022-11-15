using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using SegundoExamen.Data.Entity;
using System.Xml.Linq;
using Microsoft.Extensions.Hosting;

namespace SegundoExamen.Data
{
    public class DataContext
    {
        internal object products;

        public DataContext(dbcontext option)
        {
        }
           public DbSet<Name> Name { get; set; }
        public DbSet<type> type { get; set; }
        public DbSet<years> years { get; set; }
        public DbSet<cost> cost { get; set; }
        public object DataContext { get; internal set; }

        public DataContext(object dataContext)
        {
            DataContext = dataContext;
        }

        internal Task saveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

