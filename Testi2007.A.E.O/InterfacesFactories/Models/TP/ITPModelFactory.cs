namespace Testi2007.A.E.O.InterfacesFactories.Models.TP
{
    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.Interfaces.Contexts.TP;
    using Testi2007.A.E.O.Interfaces.Models.TP;

    public interface ITPModelFactory
    {
        ITPModel Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            ITPInputContext context);
    }
}