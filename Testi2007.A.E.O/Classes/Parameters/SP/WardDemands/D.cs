namespace Testi2007.A.E.O.Classes.Parameters.SP.WardDemands
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;

    internal sealed class D : ID
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public D(
            ImmutableList<IDParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IDParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IjIndexElement jIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }

        public decimal GetTotalDemand()
        {
            return this.Value
                .Select(x => x.Value.Value.Value)
                .Sum();
        }
    }
}