using Microsoft.EntityFrameworkCore;
using todo_list_winforms.DAL;

namespace todo_list_winforms
{
    internal static class Program
    {
        public static Context Context { get; private set; } = null!;
        [STAThread]
        static void Main()
        {
            Context = new Context();
            ApplicationConfiguration.Initialize();
            Application.Run(new TodoList());
        }
    }
}