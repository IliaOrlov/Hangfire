using System;
using Hangfire.Annotations;

namespace Hangfire.Dashboard
{
    public static class RouteCollectionOwinExtentions
    {
        [Obsolete("Use the Add(string, IDashboardDispatcher) overload instead. Will be removed in 2.0.0.")]
        public static void Add([NotNull]this RouteCollection routes, [NotNull] string pathTemplate, [NotNull] IRequestDispatcher dispatcher)
        {
            if (routes == null) throw new ArgumentNullException(nameof(routes));
            if (pathTemplate == null) throw new ArgumentNullException(nameof(pathTemplate));
            if (dispatcher == null) throw new ArgumentNullException(nameof(dispatcher));

            routes.Add(pathTemplate, new RequestDispatcherWrapper(dispatcher));
        }

        [Obsolete("Use the AddCommand(RouteCollection, string, Func<DashboardContext, bool>) overload instead. Will be removed in 2.0.0.")]
        public static void AddCommand(
            [NotNull] this RouteCollection routes, 
            [NotNull] string pathTemplate, 
            [NotNull] Func<RequestDispatcherContext, bool> command)
        {
            if (routes == null) throw new ArgumentNullException(nameof(routes));
            if (pathTemplate == null) throw new ArgumentNullException(nameof(pathTemplate));
            if (command == null) throw new ArgumentNullException(nameof(command));

            routes.AddCommand(pathTemplate, context => command(RequestDispatcherContext.FromDashboardContext(context)));
        }

        [Obsolete("Use the AddBatchCommand(RouteCollection, string, Func<DashboardContext, bool>) overload instead. Will be removed in 2.0.0.")]
        public static void AddBatchCommand(
            [NotNull] this RouteCollection routes, 
            [NotNull] string pathTemplate, 
            [NotNull] Action<RequestDispatcherContext, string> command)
        {
            if (routes == null) throw new ArgumentNullException(nameof(routes));
            if (pathTemplate == null) throw new ArgumentNullException(nameof(pathTemplate));
            if (command == null) throw new ArgumentNullException(nameof(command));

            routes.AddBatchCommand(pathTemplate, (context, jobId) => command(RequestDispatcherContext.FromDashboardContext(context), jobId));
        }

    }
}
