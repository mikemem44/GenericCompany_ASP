using EL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BDContexto : DbContext
    {
        public BDContexto():base(Conexion.Cn)
        {

        }

        public virtual DbSet<tableClient> TableClient { get; set; }

    }

    
}
