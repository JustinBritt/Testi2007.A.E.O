namespace Testi2007.A.E.O.Classes.Indices.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;

    internal sealed class i : Ii
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public i(
            ImmutableList<IiIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IiIndexElement> Value { get; }

        public IiIndexElement GetElementAt(
            Location value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}