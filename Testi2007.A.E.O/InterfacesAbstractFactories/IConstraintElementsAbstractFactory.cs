namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.SP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP;

    public interface IConstraintElementsAbstractFactory
    {
        IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory();

        IConstraints9ConstraintElementFactory CreateConstraints9ConstraintElementFactory();

        IConstraints10ConstraintElementFactory CreateConstraints10ConstraintElementFactory();

        IConstraints11ConstraintElementFactory CreateConstraints11ConstraintElementFactory();

        IConstraints12ConstraintElementFactory CreateConstraints12ConstraintElementFactory();
    }
}