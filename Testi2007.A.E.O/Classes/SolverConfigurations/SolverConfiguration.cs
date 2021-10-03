namespace Testi2007.A.E.O.Classes.SolverConfigurations
{
    using log4net;

    using Testi2007.A.E.O.Interfaces.SolverConfigurations;

    internal sealed class SolverConfiguration : ISolverConfiguration
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SolverConfiguration(
            OPTANO.Modeling.Optimization.SolverConfiguration solverConfiguration)
        {
            this.Value = solverConfiguration;
        }

        public OPTANO.Modeling.Optimization.SolverConfiguration Value { get; }
    }
}