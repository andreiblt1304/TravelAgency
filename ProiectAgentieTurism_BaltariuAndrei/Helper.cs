using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAgentieTurism_BaltariuAndrei
{
    public static class Helper
    {
        public static string CnnVal(string nume)
        {
            return ConfigurationManager.ConnectionStrings[nume].ConnectionString;
        }
    }
}
