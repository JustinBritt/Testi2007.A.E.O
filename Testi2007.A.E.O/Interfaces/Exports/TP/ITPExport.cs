namespace Testi2007.A.E.O.Interfaces.Exports.TP
{
    using System.Threading.Tasks;

    using Testi2007.A.E.O.Interfaces.Configurations.TP;
    using Testi2007.A.E.O.Interfaces.Contexts.TP;
    using Testi2007.A.E.O.Interfaces.SolverConfigurations;
    using Testi2007.A.E.O.InterfacesAbstractFactories;

    public interface ITPExport
    {
        Task<ITPOutputContext> Solve(
            IAbstractFactory abstractFactory,
            ITPConfiguration TPConfiguration,
            ITPInputContext TPInputContext,
            ISolverConfiguration solverConfiguration);
    }
}