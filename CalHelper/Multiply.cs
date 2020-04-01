using CalContract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalHelper
{
    [Export(typeof(ICalculator))]
    [ExportMetadata("CalciMetaData", "Multiply")]
    class Multiply : ICalculator
    {
        public int GetNumber(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
