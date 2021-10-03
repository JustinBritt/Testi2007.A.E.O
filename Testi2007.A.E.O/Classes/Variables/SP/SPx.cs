namespace Testi2007.A.E.O.Classes.Variables.SP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.SP;
    using Testi2007.A.E.O.Interfaces.Variables.SP;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.SP.SurgeonSessionAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.SP.SurgeonSessionAssignments;

    internal sealed class SPx : ISPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPx(
            VariableCollection<IjIndexElement, IkIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IjIndexElement, IkIndexElement> Value { get; }

        public bool GetElementAt(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            bool value = false;

            if (this.Value[jIndexElement, kIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.SP.SurgeonSessionAssignments.ISPx GetElementsAt(
            ISPxResultElementFactory SPxResultElementFactory,
            ISPxFactory SPxFactory,
            Ijk jk)
        {
            return SPxFactory.Create(
                jk.Value
                .Select(
                    i => SPxResultElementFactory.Create(
                        i.jIndexElement,
                        i.kIndexElement,
                        this.GetElementAt(
                            i.jIndexElement,
                            i.kIndexElement)))
                .ToImmutableList());
        }
    }
}