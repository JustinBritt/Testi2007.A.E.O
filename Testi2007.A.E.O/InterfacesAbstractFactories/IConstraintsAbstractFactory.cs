namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Constraints.SP;
    using Testi2007.A.E.O.InterfacesFactories.Constraints.TP;

    public interface IConstraintsAbstractFactory
    {
        IConstraint3Factory CreateConstraint3Factory();

        IConstraints4Factory CreateConstraints4Factory();

        IConstraint5Factory CreateConstraint5Factory();

        IConstraints9Factory CreateConstraints9Factory();

        IConstraints10Factory CreateConstraints10Factory();

        IConstraints11Factory CreateConstraints11Factory();

        IConstraints12Factory CreateConstraints12Factory();
    }
}