namespace Testi2007.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints11ConstraintElementFactory : IConstraints11ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints11ConstraintElementFactory()
        {
        }

        public IConstraints11ConstraintElement Create(
            IjIndexElement jIndexElement,
            Iiw iw,
            IN N,
            ITPx x)
        {
            IConstraints11ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints11ConstraintElement(
                    jIndexElement,
                    iw,
                    N,
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