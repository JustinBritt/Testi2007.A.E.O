﻿namespace Testi2007.A.E.O.InterfacesFactories.Indices.Common
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.Common;
    using Testi2007.A.E.O.Interfaces.Indices.Common;

    public interface IjFactory
    {
        Ij Create(
            ImmutableList<IjIndexElement> value);
    }
}