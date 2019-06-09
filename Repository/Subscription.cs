using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Repository
{
    public class Subscription
    {
        public enum SubscriptionType { upfront, subscribedegree, accelerated}
        public SubscriptionType TypeOfSubscription { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  MailAddress EmailAddress { get; set; }
        public int CreditCardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string SocialSecurityNumber { get; set; }

        public bool IsActive { get; set; }

        public Subscription() {}

        public Subscription(SubscriptionType typeOfSubscription, string firstName, string lastName,
            MailAddress emailAddress, int creditCardNumber, DateTime expirationDate,
            string socialSecurityNumber, bool isActive)
        {
            TypeOfSubscription = typeOfSubscription;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CreditCardNumber = creditCardNumber;
            ExpirationDate = expirationDate;
            SocialSecurityNumber = socialSecurityNumber;
            IsActive = isActive;
        }
    }
}
