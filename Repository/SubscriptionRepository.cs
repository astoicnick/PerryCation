using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private List<Subscription> _subscriptions = new List<Subscription>();

        public bool AddContentToList(Subscription ToAdd)
        {
            int initCount = _subscriptions.Count();
            _subscriptions.Add(ToAdd);
            if (initCount < _subscriptions.Count())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Subscription> GetSubscriptionList()
        {
            return _subscriptions;
        }
        public bool UpdateContent(Subscription toUpdate)
        {
            foreach (Subscription subscription in _subscriptions)
            {
                if (subscription.EmailAddress == toUpdate.EmailAddress)
                {
                    subscription.TypeOfSubscription = toUpdate.TypeOfSubscription;
                    subscription.FirstName = toUpdate.FirstName;
                    subscription.LastName = toUpdate.LastName;
                    subscription.EmailAddress = toUpdate.EmailAddress;
                    subscription.CreditCardNumber = toUpdate.CreditCardNumber;
                    subscription.ExpirationDate = toUpdate.ExpirationDate;
                    subscription.SocialSecurityNumber = toUpdate.SocialSecurityNumber;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveContent(Subscription toRemove)
        {
            foreach (Subscription subscription in _subscriptions)
            {
                if (subscription.EmailAddress == toRemove.EmailAddress)
                {
                    _subscriptions.Remove(subscription);
                    return true;
                }
            }
            return false;
        }
    }
    public class MockRepository : ISubscriptionRepository
    {
        public bool AddContentToList(Subscription subToAdd)
        {
            return true;
        }

        public List<Subscription> GetSubscriptionList()
        {
            return new List<Subscription>() { new Subscription()};
        }

        public bool RemoveContent(Subscription toRemove)
        {
            return true;
        }

        public bool UpdateContent(Subscription toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
