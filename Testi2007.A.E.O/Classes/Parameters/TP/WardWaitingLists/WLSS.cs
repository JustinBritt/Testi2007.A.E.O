namespace Testi2007.A.E.O.Classes.Parameters.TP.WardWaitingLists
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists;

    internal sealed class WLSS : IWLSS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WLSS(
            ImmutableList<IWLSSParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWLSSParameterElement> Value { get; }

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