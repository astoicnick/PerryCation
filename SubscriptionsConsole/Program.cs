using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace SubscriptionsConsole
{
    class Program
    {
        public static void Main()
        {
            var repo = new SubscriptionRepository();
            ProgramUI ui = new ProgramUI(repo, new Repository.Console());
            repo.AddInitialContent();
            ui.Run();
            
        }
    }
}
