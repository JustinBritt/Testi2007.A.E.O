namespace Testi2007.A.E.O.Factories.ConstraintElements.SP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.ConstraintElements.SP;
    using Testi2007.A.E.O.Interfaces.ConstraintElements.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Indices.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.ConstraintElements.SP;

    internal sealed class Constraints4ConstraintElementFactory : IConstraints4ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElementFactory()
        {
        }

        public IConstraints4ConstraintElement Create(
            IjIndexElement jIndexElement,
            Ik k,
            Il l,
            ISPx x)
        {
            IConstraints4ConstraintElement constraintElement = null;

            try
            {
                constraintElement = new Constraints4ConstraintElement(
                    jIndexElement,
                    k,
                    l,
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