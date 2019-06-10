using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

        public void AddInitialContent()
        {
        Subscription testOne = new Subscription(Subscription.SubscriptionType.upfront, "Nick",
                "Perry", "perry184@purdue.edu", "fakePassword123@", "1234-4215-5482-2451", "11/23",
                "123-25-4521", true);
        Subscription testTwo = new Subscription(Subscription.SubscriptionType.subscribedegree,
                "Mick", "Jerry", "kerry184@purdue.edu", "fakeBassword123@",
                "1234-4215-5482-2452", "12/23", "123-25-4521", true);
        AddContentToList(testOne);
        AddContentToList(testTwo);
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
        public void CancelSubscription(Subscription toCancel)
        {
            toCancel.IsActive = false;
        }
        public bool VerifySubscriber(string emailToVerify, string passwordToVerify)
        {
            foreach (Subscription subscription in _subscriptions)
            {
                if (emailToVerify == subscription.EmailAddress)
                {
                    if (passwordToVerify == subscription.Password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        public Subscription FindSubscriber(string email)
        {
            foreach (Subscription subscription in _subscriptions)
            {
                if (subscription.EmailAddress == email)
                {
                    return subscription;
                }
            }
            return null;
        }
    }
    public class MockRepository : ISubscriptionRepository
    {
        public bool AddContentToList(Subscription subToAdd)
        {
            return true;
        }

        public void CancelSubscription(Subscription toCancel)
        {
           return;
        }

        public Subscription FindSubscriber(string email)
        {
           return null;
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

        public bool VerifySubscriber(string emailToVerify, string passwordToVerify)
        {
            return true;
        }

    }
}
