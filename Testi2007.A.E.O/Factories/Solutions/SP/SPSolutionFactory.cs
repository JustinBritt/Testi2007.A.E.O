namespace Testi2007.A.E.O.Factories.Solutions.SP
{
    using System;

    using log4net;

    using Testi2007.A.E.O.Classes.Solutions.SP;
    using Testi2007.A.E.O.Interfaces.Solutions.SP;
    using Testi2007.A.E.O.InterfacesFactories.Solutions.SP;

    internal sealed class SPSolutionFactory : ISPSolutionFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SPSolutionFactory()
        {
        }

        public ISPSolution Create()
        {
            ISPSolution solution = null;

            try
            {
                solution = new SPSolution();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return solution;
        }
    }
}