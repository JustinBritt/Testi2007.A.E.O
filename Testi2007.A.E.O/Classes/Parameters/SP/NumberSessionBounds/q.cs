namespace Testi2007.A.E.O.Classes.Parameters.SP.NumberSessionBounds
{
    using log4net;

    using Hl7.Fhir.Model;

    using Testi2007.A.E.O.Interfaces.Parameters.SP.NumberSessionBounds;

    internal sealed class q : Iq
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public q(
            PositiveInt value)
        {
            this.Value = value;                         
        }

        public PositiveInt Value { get; }
    }
}