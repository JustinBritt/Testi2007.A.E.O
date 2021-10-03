namespace Testi2007.A.E.O.Classes.Parameters.SP.OverrunTimes
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Parameters.SP.OverrunTimes;

    internal sealed class H : IH
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public H(
            Duration value)
        {
            this.Value = value;
        }

        public Duration Value { get; }
    }
}