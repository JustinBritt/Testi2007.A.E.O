namespace Testi2007.A.E.O.Interfaces.IndexElements.TP
{
    using Hl7.Fhir.Model;

    public interface IsIndexElement
    {
        /// <summary>
        /// Gets the the surgery room type.
        /// </summary>
        PositiveInt Value { get; }
    }
}