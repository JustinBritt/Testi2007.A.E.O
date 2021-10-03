namespace Testi2007.A.E.O.Classes.Parameters.TP.WardNumberAssignedSessions
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions;

    internal sealed class N : IN
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public N(
            ImmutableList<INParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<INParameterElement> Value { get; }

        public int GetElementAtAsint(
            IjIndexElement jIndexElement)
        {
            return this.Value
                .Where(x => x.jIndexElement == jIndexElement)
                .Select(x => x.Value.Value.Value)
                .SingleOrDefault();
        }
    }
}