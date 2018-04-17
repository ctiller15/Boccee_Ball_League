using Boccee_Ball_League.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boccee_Ball_League.Context
{
    class BocceeBallContext :DbContext
    {
        public BocceeBallContext():base("name=DefaultConnection")
        {

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
