namespace Testi2007.A.E.O.Classes.Parameters.SP.WardOverrunTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.ParameterElements.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes;

    internal sealed class o : Io
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public o(
            ImmutableList<IoParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IoParameterElement> Value { get; }

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