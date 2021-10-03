namespace Testi2007.A.E.O.InterfacesFactories.Contexts.TP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.Interfaces.Contexts.TP;
    using Testi2007.A.E.O.Interfaces.Models.TP;

    public interface ITPOutputContextFactory
    {
        ITPOutputContext Create(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ITPModel TPModel,
            Solution solution);
    }
}