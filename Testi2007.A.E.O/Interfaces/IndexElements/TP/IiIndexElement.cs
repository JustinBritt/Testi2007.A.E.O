namespace Testi2007.A.E.O.Interfaces.IndexElements.TP
{
    using Hl7.Fhir.Model;

    public interface IiIndexElement
    {
        /// <summary>
        /// Gets the surgery room.
        /// </summary>
        Location Value { get; }
    }
}