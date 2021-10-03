namespace Testi2007.A.E.O.InterfacesFactories.Contexts.SP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.Interfaces.Contexts.SP;
    using Testi2007.A.E.O.Interfaces.Models.SP;

    public interface ISPOutputContextFactory
    {
        ISPOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISPModel SPModel,
            Solution solution);
    }
}