
using TargetCalculationInterfaces;

namespace TargetFormulaNalNl2
{
    internal class TargetCalculationFactoryNalNl2 : ITargetCalculationFactory
    {
        public TargetFormula GetTargetFormula()
        {
            return TargetFormula.NalNl2;
        }

        public ITargetCalculation Create()
        {
            return new TargetCalculationNalNl2();
        }
    }
}
