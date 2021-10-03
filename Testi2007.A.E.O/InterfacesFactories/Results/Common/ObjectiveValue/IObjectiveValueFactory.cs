namespace Testi2007.A.E.O.InterfacesFactories.Results.Common.ObjectiveValue
{
    using Testi2007.A.E.O.Interfaces.Results.Common.ObjectiveValue;

    public interface IObjectiveValueFactory
    {
        IObjectiveValue Create(
            decimal value);
    }
}