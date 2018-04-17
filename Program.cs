using Boccee_Ball_League.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Boccee_Ball_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BocceeBallContext();

            db.SaveChanges();
        }
    }
}
