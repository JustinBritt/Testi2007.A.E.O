namespace Testi2007.A.E.O.Interfaces.IndexElements.Common
{
    using Hl7.Fhir.Model;

    public interface IjIndexElement
    {
        /// <summary>
        /// Gets the ward.
        /// </summary>
        Organization Value { get; }
    }
}