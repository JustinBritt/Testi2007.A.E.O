namespace Testi2007.A.E.O.Factories.Parameters.SP.WardSessionDemandMarginalBenefits
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Classes.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.InterfacesFactories.Parameters.SP.WardSessionDemandMarginalBenefits;

    internal sealed class dFactory : IdFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public dFactory()
        {
        }

        public Id Create(
            ImmutableList<IdParameterElement> value)
        {
            Id parameter = null;

            try
            {
                parameter = new d(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}