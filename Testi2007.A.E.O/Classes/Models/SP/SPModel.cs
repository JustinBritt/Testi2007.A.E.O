namespace Testi2007.A.E.O.Classes.Models.SP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.Interfaces.Contexts.SP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.SP;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Indices.SP;
    using Testi2007.A.E.O.Interfaces.Models.SP;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.DemandWeights;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.NumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.OverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardDemands;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardOverrunTimes;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardServiceRates;
    using Testi2007.A.E.O.Interfaces.Parameters.SP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Variables.SP;

    internal sealed class SPModel : ISPModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPModel(
            ICalculationsAbstractFactory calculationsAbstractFactory,
            IConstraintElementsAbstractFactory constraintElementsAbstractFactory,
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IIndicesAbstractFactory indicesAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IParametersAbstractFactory parametersAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            ISPInputContext context)
        {
            this.Context = context;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices
            this.j = indicesAbstractFactory.CreatejFactory().Create(
                this.Context.Wards
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            this.k = indicesAbstractFactory.CreatekFactory().Create(
                this.Context.Sessions
                .Select(x => indexElementsAbstractFactory.CreatekIndexElementFactory().Create(x))
                .ToImmutableList());

            // Cross joins

            // jk
            this.jk = crossJoinsAbstractFactory.CreatejkFactory().Create(
                this.j.Value
                .SelectMany(b => this.k.Value, (a, b) => crossJoinElementsAbstractFactory.CreatejkCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // DS(j)
            this.DS = parametersAbstractFactory.CreateDSFactory().Create(
                this.Context.WardPastDemands
                .Select(
                    x => parameterElementsAbstractFactory.CreateDSParameterElementFactory().Create(
                        this.j.GetElementAt(x.Item1),
                        x.Item2))
                .ToImmutableList());

            // H
            this.H = parametersAbstractFactory.CreateHFactory().Create(
                this.Context.MaximumNumberSessionOverrunHours);

            // l(j)
            this.l = parametersAbstractFactory.CreateSPlFactory().Create(
                this.Context.WardLowerSessionBounds
                .Select(
                    x => parameterElementsAbstractFactory.CreateSPlParameterElementFactory()
                    .Create(
                        this.j.GetElementAt(x.Item1),
                        x.Item2))
                .ToImmutableList());

            // o(j)
            this.o = parametersAbstractFactory.CreateoFactory().Create(
                this.Context.WardOverrunTimes
                .Select(
                    x => parameterElementsAbstractFactory.CreateoParameterElementFactory()
                    .Create(
                        this.j.GetElementAt(x.Item1),
                        x.Item2))
                .ToImmutableList());

            // q
            this.q = parametersAbstractFactory.CreateqFactory().Create(
                this.Context.MaximumNumberSessions);

            // WL(j)
            this.WL = parametersAbstractFactory.CreateWLFactory().Create(
                this.Context.WardWaitingListLengths
                .Select(
                    x => parameterElementsAbstractFactory.CreateWLParameterElementFactory().Create(
                        this.j.GetElementAt(x.Item1),
                        x.Item2))
                .ToImmutableList());

            // α
            this.α = parametersAbstractFactory.CreateαFactory().Create(
                this.Context.α);

            // β
            this.β = parametersAbstractFactory.CreateβFactory().Create(
                this.Context.β);

            // μ(j)
            this.μ = parametersAbstractFactory.CreateμFactory().Create(
                this.Context.WardServiceRates
                .Select(
                    x => parameterElementsAbstractFactory.CreateμParameterElementFactory().Create(
                        this.j.GetElementAt(x.Item1),
                        x.Item2))
                .ToImmutableList());

            // DL(j)
            this.DL = calculationsAbstractFactory.CreateDLCalculationFactory().Create().CalculateDL(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                parameterElementsAbstractFactory.CreateDLParameterElementFactory(),
                parametersAbstractFactory.CreateDLFactory(),
                this.j,
                this.WL,
                this.μ);

            // D(j)
            this.D = calculationsAbstractFactory.CreateDCalculationFactory().Create().CalculateD(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                parameterElementsAbstractFactory.CreateDParameterElementFactory(),
                parametersAbstractFactory.CreateDFactory(),
                this.j,
                this.DL,
                this.DS,
                this.α,
                this.β);

            // d(j, k)
            this.d = calculationsAbstractFactory.CreatedCalculationFactory().Create().Calculated(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                parameterElementsAbstractFactory.CreatedParameterElementFactory(),
                parametersAbstractFactory.CreatedFactory(),
                this.jk,
                this.D);

            // Variables

            // x(j, k)
            this.x = variablesAbstractFactory.CreateSPxFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.j.Value, 
                    indexSet2: this.k.Value, 
                    lowerBoundGenerator: (a, b) => 0,
                    upperBoundGenerator: (a, b) => 1, 
                    variableTypeGenerator: (a, b) => VariableType.Binary)); 

            // Constraints

            // Constraint (3)
            this.Model.AddConstraint(
                constraintsAbstractFactory.CreateConstraint3Factory().Create(
                    this.jk,
                    this.q,
                    this.x)
                .Value);

            // Constraints (4)
            this.Model.AddConstraints(
                this.j.Value
                .Select(
                    y => constraintElementsAbstractFactory.CreateConstraints4ConstraintElementFactory().Create(
                        y,
                        this.k,
                        this.l,
                        this.x)
                    .Value));

            // Constraint (5)
            this.Model.AddConstraint(
                constraintsAbstractFactory.CreateConstraint5Factory().Create(
                    this.jk,
                    this.H,
                    this.o,
                    this.x)
                .Value);

            // Objective function
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateSPObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.jk,
                    this.d,
                    this.x)
                .Value);
        }

        public ISPInputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Ij j { get; }

        public Ik k { get; }

        public Ijk jk { get; }

        public ID D { get; }

        public Testi2007.A.E.O.Interfaces.Parameters.SP.WardSessionDemandMarginalBenefits.Id d { get; }

        public IDL DL { get; }

        public IDS DS { get; }

        public IH H { get; }

        public Il l { get; }

        public Io o { get; }

        public Iq q { get; }

        public IWL WL { get; }

        public Iα α { get; }

        public Iβ β { get; }

        public Iμ μ { get; }

        public ISPx x { get; }
    }
}