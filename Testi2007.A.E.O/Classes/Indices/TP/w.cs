namespace Testi2007.A.E.O.Classes.Indices.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;

    internal sealed class w : Iw
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w(
            ImmutableList<IwIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IwIndexElement> Value { get; }

        public IwIndexElement GetElementAt(
            FhirDateTime value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}