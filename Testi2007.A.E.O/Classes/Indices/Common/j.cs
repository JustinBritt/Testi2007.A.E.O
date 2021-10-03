namespace Testi2007.A.E.O.Classes.Indices.Common
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Indices.Common;

    internal sealed class j : Ij
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public j(
            ImmutableList<IjIndexElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IjIndexElement> Value { get; }

        public IjIndexElement GetElementAt(
            Organization value)
        {
            return this.Value
                .Where(x => x.Value == value)
                .SingleOrDefault();
        }
    }
}