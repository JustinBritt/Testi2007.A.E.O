namespace Testi2007.A.E.O.Classes.Variables.TP
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Variables.TP;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.TP.OperatingRoomWardDayAssignments;

    internal sealed class TPx : ITPx
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPx(
            VariableCollection<IiIndexElement, IjIndexElement, IwIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IiIndexElement, IjIndexElement, IwIndexElement> Value { get; }

        public bool GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement)
        {
            bool value = false;

            if (this.Value[iIndexElement, jIndexElement, wIndexElement].Value.IsAlmost(1))
            {
                value = true;
            }

            return value;
        }

        public Interfaces.Results.TP.OperatingRoomWardDayAssignments.ITPx GetElementsAt(
            ITPxResultElementFactory TPxResultElementFactory,
            ITPxFactory TPxFactory,
            Iijw ijw)
        {
            return TPxFactory.Create(
                ijw.Value
                .Select(
                    i => TPxResultElementFactory.Create(
                        i.iIndexElement,
                        i.jIndexElement,
                        i.wIndexElement,
                        this.GetElementAt(
                            i.iIndexElement,
                            i.jIndexElement,
                            i.wIndexElement)))
                .ToImmutableList());
        }
    }
}