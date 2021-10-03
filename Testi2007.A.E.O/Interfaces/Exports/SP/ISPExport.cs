namespace Testi2007.A.E.O.Interfaces.Exports.SP
{
    using System.Threading.Tasks;

    using Testi2007.A.E.O.Interfaces.Configurations.SP;
    using Testi2007.A.E.O.Interfaces.Contexts.SP;
    using Testi2007.A.E.O.Interfaces.SolverConfigurations;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    public interface ISPExport
    {
        Task<ISPOutputContext> Solve(
            IAbstractFactory abstractFactory,
            ISPConfiguration SPConfiguration,
            ISPInputContext SPInputContext,
            ISolverConfiguration solverConfiguration);
    }
}