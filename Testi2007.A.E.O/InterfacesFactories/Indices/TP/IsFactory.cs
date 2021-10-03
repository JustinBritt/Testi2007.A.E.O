﻿namespace Testi2007.A.E.O.InterfacesFactories.Indices.TP
{
    using System.Collections.Immutable;

    using Testi2007.A.E.O.Interfaces.IndexElements.TP;
    using Testi2007.A.E.O.Interfaces.Indices.TP;

    public interface IsFactory
    {
        Is Create(
            ImmutableList<IsIndexElement> value);
    }
}