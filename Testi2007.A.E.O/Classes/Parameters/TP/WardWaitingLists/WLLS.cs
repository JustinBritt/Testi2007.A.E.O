namespace Testi2007.A.E.O.Classes.Parameters.TP.WardWaitingLists
{
    using System.Collections.Immutable;

    using log4net;

    using Testi2007.A.E.O.Interfaces.ParameterElements.TP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists;

    internal sealed class WLLS : IWLLS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WLLS(
            ImmutableList<IWLLSParameterElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IWLLSParameterElement> Value { get; }
    }
}