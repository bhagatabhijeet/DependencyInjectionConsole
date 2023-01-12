using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIConsole
{
    internal interface Interface1
    {
        ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
    }
}
