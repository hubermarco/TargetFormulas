
using TargetCalculationInterfaces;

namespace TargetFormulaNalNl2
{
    public class TargetCalculationFactoryNalNl2 : ITargetCalculationFactory
    {
        public TargetFormula GetTargetFormula()
        {
            return TargetFormula.NalNl2;
        }

        public ITargetCalculationParameters CreateTargetCalculationParameters()
        {
            return new TargetCalculationParametersNalNl2();
        }

        public ITargetCalculation Create()
        {
            return new TargetCalculationNalNl2();
        }
    }
}
