using System;
using System.Collections.Generic;
using System.Text;
using TargetCalculationInterfaces;

namespace TargetFormulaNalNl2
{
    internal class TargetCalculationNalNl2 : ITargetCalculation
    {
        public IList<FreqCrv> Calculate(ITargetCalculationParameters targetCalculationParameters)
        {
            return new List<FreqCrv>();
        }
    }
}
