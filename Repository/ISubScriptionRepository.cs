using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Repository
{
    public interface ISubscriptionRepository
    {
        bool AddContentToList(Subscription subToAdd);
        List<Subscription> GetSubscriptionList();
        bool UpdateContent(Subscription toUpdate);
        bool RemoveContent(Subscription toRemove);
        void CancelSubscription(Subscription toCancel);
        bool VerifySubscriber(string emailToVerify, string passwordToVerify);
        Subscription FindSubscriber(string email);
    }
}
