namespace Testi2007.A.E.O.Classes.Parameters.TP.WardDayPreferences
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;

    internal sealed class p : Ip
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public p(
            ImmutableList<IpParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IpParameterElement> Value { get; }

        public int GetElementAtAsint(
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement && x.wIndexElement == wIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}