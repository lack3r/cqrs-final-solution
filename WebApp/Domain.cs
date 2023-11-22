using Cafe.Tab;
using CafeReadModels;
using ISXTraining.CQRS;

namespace WebFrontend
{
    public static class Domain
    {
        private static MessageDispatcher dispatcher;
        private static IOpenTabQueries openTabQueries;
        private static IChefTodoListQueries chefTodoListQueries;

        public static IOpenTabQueries OpenTabQueries { get => openTabQueries; set => openTabQueries = value; }
        public static IChefTodoListQueries ChefTodoListQueries { get => chefTodoListQueries; set => chefTodoListQueries = value; }
        public static MessageDispatcher Dispatcher { get => dispatcher; set => dispatcher = value; }

        public static void Setup()
        {
            Dispatcher = new MessageDispatcher(new InMemoryEventStore());

            Dispatcher.ScanInstance(new TabAggregate());

            OpenTabQueries = new OpenTabs();
            Dispatcher.ScanInstance(OpenTabQueries);

            ChefTodoListQueries = new ChefTodoList();
            Dispatcher.ScanInstance(ChefTodoListQueries);
        }
    }
}