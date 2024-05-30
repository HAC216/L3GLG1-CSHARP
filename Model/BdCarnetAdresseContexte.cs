using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AppGestionAdress.Model
{
    public class BdCarnetAdresseContexte:DbContext
    {

        public BdCarnetAdresseContexte() : base("connBdCarnetAdresse")
        {

        
        }

        public DbSet<CarnetAdresse> CarnetAdresses { get; set; }
    }
}
