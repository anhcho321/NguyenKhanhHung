using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    public class DBShapeContext : DbContext
    {
        public DBShapeContext() : base("name=DBEntityShape")
        {

        }
        public DbSet<ListShape> tbListShapes{set; get; }
    }
}
