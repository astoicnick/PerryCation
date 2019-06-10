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
        public  string EmailAddress { get; set; }
        public string Password { get; set; }
        public string CreditCardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string SocialSecurityNumber { get; set; }
        public bool IsActive { get; set; }

        public Subscription() {}

        public Subscription(SubscriptionType typeOfSubscription, string firstName, string lastName,
            string emailAddress, string password, string creditCardNumber, string expirationDate,
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
            Password = password;
        }
    }
}
