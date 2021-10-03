namespace Testi2007.A.E.O.Interfaces.Models.TP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    public interface ITPModel
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Iijw ijw { get; }

        ITPx x { get; }
    }
}