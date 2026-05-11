using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Infrastructure.Options
{
   public class ConnectionStringOptions 
    {
        public static string SectionName { get; } = "ConnectionStrings";
        public string DefaultConnection { get; set; }

        public ConnectionStringOptions Value => throw new NotImplementedException();
    }
}
