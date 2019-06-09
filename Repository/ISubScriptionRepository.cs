using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    interface ISubscriptionRepository
    {
        bool AddContentToList(Subscription subToAdd);
        List<Subscription> GetSubscriptionList();
        bool UpdateContent(Subscription toUpdate);
        bool RemoveContent(Subscription toRemove);

    }
}
