namespace Testi2007.A.E.O.InterfacesAbstractFactories
{
    using Testi2007.A.E.O.InterfacesFactories.Exports.SP;
    using Testi2007.A.E.O.InterfacesFactories.Exports.TP;

    public interface IExportsAbstractFactory
    {
        ISPExportFactory CreateSPExportFactory();

        ITPExportFactory CreateTPExportFactory();
    }
}