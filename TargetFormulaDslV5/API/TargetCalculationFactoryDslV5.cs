using TargetCalculationInterfaces;

namespace TargetFormulaDslV5
{
    public class TargetCalculationFactoryDslV5 : ITargetCalculationFactory
    {
        public TargetFormula GetTargetFormula()
        {
            return TargetFormula.DslV5;
        }

        public ITargetCalculation Create()
        {
            return new TargetCalculationDslV5();
        }
    }
}