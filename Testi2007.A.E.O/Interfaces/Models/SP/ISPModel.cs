namespace Testi2007.A.E.O.Interfaces.Models.SP
{
    using OPTANO.Modeling.Optimization;

    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    public interface ISPModel
    {
        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        Model Model { get; }

        Ijk jk { get; }

        ISPx x { get; }
    }
}