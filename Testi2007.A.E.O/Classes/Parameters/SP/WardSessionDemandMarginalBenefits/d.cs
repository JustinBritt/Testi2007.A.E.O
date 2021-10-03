namespace Testi2007.A.E.O.Classes.Parameters.SP.WardSessionDemandMarginalBenefits
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardSessionDemandMarginalBenefits;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits;

    internal sealed class d : Id
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d(
            ImmutableList<IdParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IdParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement && x.kIndexElement == kIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}