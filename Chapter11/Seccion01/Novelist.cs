using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion01
{
    class Novelist
    {

        public string Name { get; set; }
        public string KanaName { get; set; }
        public string Birth { get; set; }
        public string Death { get; set; }
        public IEnumerable<string> MasterPieses { get; set; }

    }
}
