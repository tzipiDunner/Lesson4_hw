using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public static  class Utilities
    {
        public static EmailBL ConfigEmailDependencies(string v)
        {
            switch (v)
            {
                case "Mock": return new EmailBL(new MockDataSorse());
                case "SQL":
                default:
                    return new EmailBL(new SQLDataSorce());
            }
        }
    }
}
