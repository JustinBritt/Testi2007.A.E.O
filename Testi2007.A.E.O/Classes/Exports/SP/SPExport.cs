﻿namespace Testi2007.A.E.O.Classes.Exports.SP
{
    using System.Threading.Tasks;

    using log4net;

    using Testi2007.A.E.O.Interfaces.Configurations.SP;
    using Testi2007.A.E.O.Interfaces.Contexts.SP;
    using Testi2007.A.E.O.Interfaces.Exports.SP;
    using Testi2007.A.E.O.Interfaces.SolverConfigurations;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    internal sealed class SPExport : ISPExport
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPExport()
        {
        }

        public Task<ISPOutputContext> Solve(
            IAbstractFactory abstractFactory,
            ISPConfiguration SPConfiguration,
            ISPInputContext SPInputContext,
            ISolverConfiguration solverConfiguration)
        {
            return abstractFactory.CreateSolutionsAbstractFactory().CreateSPSolutionFactory().Create().Solve(
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
                SPConfiguration,
                SPInputContext,
                solverConfiguration);
        }
    }
}