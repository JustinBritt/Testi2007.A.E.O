﻿namespace Testi2007.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization
{
    using global::OPTANO.Modeling.Optimization.Interfaces;

    using Testi2007.A.E.O.Interfaces.SolverConfigurations;

    public interface ISolverFactory
    {
        ISolver Create(
            ISolverConfiguration solverConfiguration);
    }
}