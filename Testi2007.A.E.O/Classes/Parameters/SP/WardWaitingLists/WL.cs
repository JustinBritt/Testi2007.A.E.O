namespace Testi2007.A.E.O.Classes.Parameters.SP.WardWaitingLists
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardWaitingLists;

    internal sealed class WL : IWL
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WL(
            ImmutableList<IWLParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWLParameterElement> Value { get; }

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