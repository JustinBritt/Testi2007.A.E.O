namespace Testi2007.A.E.O.Classes.Exports.TP
{
    using System.Threading.Tasks;

    using log4net;

    using Testi2007.A.E.O.Interfaces.Configurations.TP;
    using Testi2007.A.E.O.Interfaces.Contexts.TP;
    using Testi2007.A.E.O.Interfaces.Exports.TP;
    using Testi2007.A.E.O.Interfaces.SolverConfigurations;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class TPExport : ITPExport
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPExport()
        {
        }

        public Task<ITPOutputContext> Solve(
            IAbstractFactory abstractFactory,
            ITPConfiguration TPConfiguration,
            ITPInputContext TPInputContext,
            ISolverConfiguration solverConfiguration)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateTPSolutionFactory().Create().Solve(
                abstractFactory.CreateCalculationsAbstractFactory(),
                abstractFactory.CreateConstraintElementsAbstractFactory(),
                abstractFactory.CreateConstraintsAbstractFactory(),
                abstractFactory.CreateContextsAbstractFactory(),
                abstractFactory.CreateCrossJoinElementsAbstractFactory(),
                abstractFactory.CreateCrossJoinsAbstractFactory(),
                abstractFactory.CreateDependenciesAbstractFactory(),
                abstractFactory.CreateIndexElementsAbstractFactory(),
                abstractFactory.CreateIndicesAbstractFactory(),
                abstractFactory.CreateModelsAbstractFactory(),
                abstractFactory.CreateObjectiveFunctionsAbstractFactory(),
                abstractFactory.CreateParameterElementsAbstractFactory(),
                abstractFactory.CreateParametersAbstractFactory(),
                abstractFactory.CreateResultElementsAbstractFactory(),
                abstractFactory.CreateResultsAbstractFactory(),
                abstractFactory.CreateVariablesAbstractFactory(),
                TPConfiguration,
                TPInputContext,
                solverConfiguration);
        }
    }
}