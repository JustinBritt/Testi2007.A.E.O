namespace Testi2007.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints9ConstraintElementFactory : IConstraints9ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElementFactory()
        {
        }

        public IConstraints9ConstraintElement Create(
            IiIndexElement iIndexElement,
            IwIndexElement wIndexElement,
            Ij j,
            ITPx x)
        {
            IConstraints9ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints9ConstraintElement(
                    iIndexElement,
                    wIndexElement,
                    j,
                    x);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return constraintElement;
        }
    }
}