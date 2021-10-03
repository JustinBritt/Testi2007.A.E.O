namespace Testi2007.A.E.O.Classes.Parameters.TP.WardNumberOperatingTeams
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;

    internal sealed class e : Ie
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public e(
            ImmutableList<IeParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IeParameterElement> Value { get; }

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