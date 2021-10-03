namespace Testi2007.A.E.O.Classes.Parameters.SP.WardServiceRates
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardServiceRates;

    internal sealed class μ : Iμ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public μ(
            ImmutableList<IμParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IμParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}