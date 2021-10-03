namespace Testi2007.A.E.O.Interfaces.IndexElements.TP
{
    using Hl7.Fhir.Model;

    public interface IwIndexElement
    {
        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        FhirDateTime Value { get; }
    }
}