using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriptionsConsole
{
    public class ProgramUI
    {
        private readonly ISubscriptionRepository _repo;
        private readonly IConsole _console;
        public ProgramUI(ISubscriptionRepository repo, IConsole  console)
        {
            _repo = repo;
            _console = console;
        }

        public void Run() {
            while (Menu())
            {
            }
        }
        private bool Menu()
        {
            System.Console.WriteLine("Subscription Dashboard:\n" +
                "1. Create new subscribers \n" +
                "2. Read list of subscribers\n" +
                "3. Update a current subscriber\n" +
                "4. Remove a subscriber\n" +
                "5. Cancel(Pause) a subscription\n" +
                "6. Verify a subscription\n" +
                "7. Exit");
            string userCase = _console.Readline();
            switch (userCase)
            {
                case ("1"):
                    _repo.AddContentToList(GetSubscriberInfo());
                    ReadKey();
                    break;
                case ("2"):
                    DisplayList();
                    ReadKey();
                    break;
                case ("3"):
                    System.Console.WriteLine("Please enter updated info...");
                    _repo.UpdateContent(GetSubscriberInfo());
                    ReadKey();
                    break;
                case ("4"):
                    _repo.RemoveContent(_repo.FindSubscriber(GetEmail()));
                    ReadKey();
                    break;
                case ("5"):
                    _repo.CancelSubscription(_repo.FindSubscriber(GetEmail()));
                    ReadKey();
                    break;
                case ("6"):
                    _repo.VerifySubscriber(GetEmail(), GetPassword());
                    ReadKey();
                    break;
                case ("7"):
                    return false;
                    break;
                default:
                    System.Console.WriteLine("Try that again");
                    break;
            }
            return true;
        }
        Subscription GetSubscriberInfo()
        {
            Subscription newSub = new Subscription();
            System.Console.WriteLine("Subscription Type(Upfront, Degreepay, Accelerated)");
            string subTypeInput = _console.Readline();
            foreach (Subscription.SubscriptionType type in Enum.GetValues(typeof(Subscription.SubscriptionType)))
            {
                if (subTypeInput.ToLower() == type.ToString().ToLower())
                {
                    newSub.TypeOfSubscription = type;
                }
            }

            System.Console.WriteLine("First Name:");
            newSub.FirstName = _console.Readline();

            System.Console.WriteLine("Last Name:");
            newSub.LastName = _console.Readline();

            System.Console.WriteLine("E-mail Address:");
            newSub.EmailAddress = _console.Readline();

            System.Console.WriteLine("Password:");
            newSub.Password = _console.Readline();

            System.Console.WriteLine("Credit Card Number:");
            newSub.CreditCardNumber = _console.Readline();

            System.Console.WriteLine("Expiration Date:");
            newSub.ExpirationDate = _console.Readline();

            System.Console.WriteLine("Social Security Number(for identity verification):");
            newSub.SocialSecurityNumber = _console.Readline();

            newSub.IsActive = true;
            return newSub;
        }
        string GetEmail()
        {
            System.Console.WriteLine("Please enter the E-mail Address:");
            return _console.Readline();
        }
        string GetPassword()
        {
            System.Console.WriteLine("Please enter Password:");
            return _console.Readline();
        }
        void DisplayList()
        {
            foreach (Subscription sub in _repo.GetSubscriptionList())
            {
                System.Console.WriteLine(sub.TypeOfSubscription);
                System.Console.WriteLine(sub.FirstName);
                System.Console.WriteLine(sub.LastName);
                System.Console.WriteLine(sub.EmailAddress);
                System.Console.WriteLine(sub.Password);
                System.Console.WriteLine(sub.CreditCardNumber);
                System.Console.WriteLine(sub.ExpirationDate);
                System.Console.WriteLine(sub.SocialSecurityNumber);
                System.Console.WriteLine(sub.IsActive);
                System.Console.WriteLine("----------------------");
            }
        }
        void ReadKey()
        {
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
