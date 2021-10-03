namespace Testi2007.A.E.O.Classes.Indices.SP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.Indices.SP;

    internal sealed class k : Ik
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public k(
            ImmutableList<IkIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IkIndexElement> Value { get; }

        public IkIndexElement GetElementAt(
            PositiveInt value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}