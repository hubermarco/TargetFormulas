using System;
using System.Collections.Generic;
using System.Text;
using TargetCalculationInterfaces;

namespace TargetFormulaDslV5
{
    internal class TargetCalculationDslV5 : ITargetCalculation
    {
        public IList<FreqCrv> Calculate(ITargetCalculationParameters targetCalculationParameters)
        {
            return new List<FreqCrv>();
        }
    }
}