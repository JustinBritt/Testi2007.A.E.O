namespace Testi2007.A.E.O.Classes.Parameters.SP.WardNumberSessionBounds
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds;

    internal sealed class l : Il
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public l(
            ImmutableList<IlParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IlParameterElement> Value { get; }

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