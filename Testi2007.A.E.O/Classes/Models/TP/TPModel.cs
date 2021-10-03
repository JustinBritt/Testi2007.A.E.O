namespace Testi2007.A.E.O.Classes.Models.TP
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;
    using OPTANO.Modeling.Optimization.Enums;

    using Testi2007.A.E.O.InterfacesAbstractFactories;
    using Testi2007.A.E.O.Interfaces.Contexts.TP;
    using Testi2007.A.E.O.Interfaces.CrossJoins.TP;
    using Testi2007.A.E.O.Interfaces.Indices.Common;
    using Testi2007.A.E.O.Interfaces.Indices.TP;
    using Testi2007.A.E.O.Interfaces.Models.TP;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.SurgeryRoomTypeSubsetSurgeryRooms;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardDayPreferences;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberOperatingTeams;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardNumberAssignedSessions;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardSurgeryRoomNumberSessionBounds;
    using Testi2007.A.E.O.Interfaces.Parameters.TP.WardWaitingLists;
    using Testi2007.A.E.O.Interfaces.Variables.TP;

    internal sealed class TPModel : ITPModel
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public TPModel(
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
            ITPInputContext context)
        {
            this.Context = context;

            this.Model = dependenciesAbstractFactory.CreateModelFactory().Create();

            // Indices
            this.i = indicesAbstractFactory.CreateiFactory().Create(
                this.Context.SurgeryRooms
                .Entry
                .Where(x => x.Resource is Location)
                .Select(x => indexElementsAbstractFactory.CreateiIndexElementFactory().Create((Location)x.Resource))
                .ToImmutableList());

            this.j = indicesAbstractFactory.CreatejFactory().Create(
                this.Context.Wards
                .Entry
                .Where(x => x.Resource is Organization)
                .Select(x => indexElementsAbstractFactory.CreatejIndexElementFactory().Create((Organization)x.Resource))
                .ToImmutableList());

            this.s = indicesAbstractFactory.CreatesFactory().Create(
                this.Context.SurgeryRoomTypes
                .Select(x => indexElementsAbstractFactory.CreatesIndexElementFactory().Create(x))
                .ToImmutableList());

            this.w = indicesAbstractFactory.CreatewFactory().Create(
                this.Context.Days
                .Select(x => indexElementsAbstractFactory.CreatewIndexElementFactory().Create(
                    x.Key.Value.Value,
                    x.Value))
                .ToImmutableList());

            // Cross joins

            // ijw
            this.ijw = crossJoinsAbstractFactory.CreateijwFactory().Create(
                this.i.Value
                .SelectMany(b => this.j.Value, (a, b) => crossJoinElementsAbstractFactory.CreateijCrossJoinElementFactory().Create(a, b))
                .SelectMany(b => this.w.Value, (a, b) => crossJoinElementsAbstractFactory.CreateijwCrossJoinElementFactory().Create(a.iIndexElement, a.jIndexElement, b))
                .ToImmutableList());

            // iw
            this.iw = crossJoinsAbstractFactory.CreateiwFactory().Create(
                this.i.Value
                .SelectMany(b => this.w.Value, (a, b) => crossJoinElementsAbstractFactory.CreateiwCrossJoinElementFactory().Create(a, b))
                .ToImmutableList());

            // Parameters

            // I(s)
            this.I = parametersAbstractFactory.CreateIFactory().Create(
                this.Context.SurgeryRoomSubsets
                .Select(x => parameterElementsAbstractFactory.CreateIParameterElementFactory().Create(
                    this.s.GetElementAt(x.Item2),
                    this.i.GetElementAt(x.Item1)))
                .ToImmutableList());

            // l(j, s)
            this.l = parametersAbstractFactory.CreateTPlFactory().Create(
                this.Context.WardSurgeryRoomTypeLowerSessionBounds
                .Select(x => parameterElementsAbstractFactory.CreateTPlParameterElementFactory().Create(
                    this.j.GetElementAt(x.Item1),
                    this.s.GetElementAt(x.Item2),
                    x.Item3))
                .ToImmutableList());

            // N(j) = sum(j)x(j,w)
            this.N = parametersAbstractFactory.CreateNFactory().Create(
                this.Context.WardNumberAssignedSessions
                .Select(x => parameterElementsAbstractFactory.CreateNParameterElementFactory().Create(
                    this.j.GetElementAt(x.Item1),
                    x.Item2))
                .ToImmutableList());

            // WLSS(j)
            this.WLSS = parametersAbstractFactory.CreateWLSSFactory().Create(
                this.Context.WardShortStayWaitingListLengths
                .Select(x => parameterElementsAbstractFactory.CreateWLSSParameterElementFactory().Create(
                    this.j.GetElementAt(x.Item1),
                    x.Item2))
                .ToImmutableList());

            // p(j, w)
            this.p = calculationsAbstractFactory.CreatepCalculationFactory().Create().Calculatep(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                parameterElementsAbstractFactory.CreatepParameterElementFactory(),
                parametersAbstractFactory.CreatepFactory(),
                this.jw,
                this.WLSS);

            // e(j)
            this.e = calculationsAbstractFactory.CreateeCalculationFactory().Create().Calculatee(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                parameterElementsAbstractFactory.CreateeParameterElementFactory(),
                parametersAbstractFactory.CreateeFactory(),
                j,
                this.Context.WardOperatingTeams);

            // Variables

            // x(i, j, w)
            this.x = variablesAbstractFactory.CreateTPxFactory().Create(
                dependenciesAbstractFactory.CreateVariableCollectionFactory().Create(
                    model: this.Model, 
                    indexSet1: this.i.Value, 
                    indexSet2: this.j.Value, 
                    indexSet3: this.w.Value, 
                    lowerBoundGenerator: (a, b, c) => 0, 
                    upperBoundGenerator: (a, b, c) => 1, 
                    variableTypeGenerator: (a, b, c) => VariableType.Binary)); 

            // Constraints

            // Constraints (9)
            this.Model.AddConstraints(
                this.iw.Value
                .Select(
                    y => constraintElementsAbstractFactory.CreateConstraints9ConstraintElementFactory().Create(
                        y.iIndexElement,
                        y.wIndexElement,
                        this.j,
                        this.x)
                    .Value));

            // Constraints (10)
            this.Model.AddConstraints(
                this.jw.Value
                .Select(
                    y => constraintElementsAbstractFactory.CreateConstraints10ConstraintElementFactory().Create(
                        y.jIndexElement,
                        y.wIndexElement,
                        this.i,
                        this.e,
                        this.x)
                    .Value));

            // Constraints (11)
            this.Model.AddConstraints(
                this.j.Value
                .Select(
                    y => constraintElementsAbstractFactory.CreateConstraints11ConstraintElementFactory().Create(
                        y,
                        this.iw,
                        this.N,
                        this.x)
                    .Value));

            // Constraints (12)
            this.Model.AddConstraints(
                this.js.Value
                .Select(
                    y => constraintElementsAbstractFactory.CreateConstraints12ConstraintElementFactory().Create(
                        y.jIndexElement,
                        y.sIndexElement,
                        this.iw,
                        this.I,
                        this.l,
                        this.x)
                    .Value));

            // Objective function
            this.Model.AddObjective(
                objectiveFunctionsAbstractFactory.CreateTPObjectiveFunctionFactory().Create(
                    dependenciesAbstractFactory.CreateObjectiveFactory(),
                    this.ijw,
                    this.p,
                    this.x)
                .Value);
        }

        public ITPInputContext Context { get; }

        /// <summary>
        /// Gets the Model instance.
        /// </summary>
        public Model Model { get; }

        public Ii i { get; }

        public Ij j { get; }

        public Is s { get; }

        public Iw w { get; }

        public Iijw ijw { get; }

        public Iiw iw { get; }

        public Ijs js { get; }

        public Ijw jw { get; }

        public Ie e { get; }

        public II I { get; }

        public Il l { get; }

        public IN N { get; }

        public Ip p { get; }

        public IWLSS WLSS { get; }

        public ITPx x { get; }
    }
}