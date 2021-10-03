namespace Testi2007.A.E.O.Classes.Indices.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;

    internal sealed class s : Is
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public s(
            ImmutableList<IsIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IsIndexElement> Value { get; }

        public IsIndexElement GetElementAt(
            PositiveInt value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}