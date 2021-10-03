namespace Testi2007.A.E.O.Interfaces.Variables.TP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.InterfacesFactories.ResultElements.TP.OperatingRoomWardDayAssignments;
    using Testi2007.A.E.O.InterfacesFactories.Results.TP.OperatingRoomWardDayAssignments;

    public interface ITPx
    {
        VariableCollection<IiIndexElement, IjIndexElement, IwIndexElement> Value { get; }

        bool GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IwIndexElement wIndexElement);

        Interfaces.Results.TP.OperatingRoomWardDayAssignments.ITPx GetElementsAt(
            ITPxResultElementFactory TPxResultElementFactory,
            ITPxFactory TPxFactory,
            Iijw ijw);
    }
}