namespace Testi2007.A.E.O.Factories.ConstraintElements.TP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.ConstraintElements.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.TP;

    internal sealed class Constraints10ConstraintElementFactory : IConstraints10ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints10ConstraintElementFactory()
        {
        }

        public IConstraints10ConstraintElement Create(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement,
            Ii i,
            Ie e,
            ITPx x)
        {
            IConstraints10ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints10ConstraintElement(
                    jIndexElement,
                    wIndexElement,
                    i,
                    e,
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