using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using SubscriptionsConsole;

namespace SubscriptionTests
{
    [TestClass]
    public class SubscriptionTest
    {
        [TestMethod]
        public void UITest()
        {
            Subscription testOne = new Subscription(Subscription.SubscriptionType.upfront, "Nick",
                "Perry", "perry184@purdue.edu", "fakePassword123@", "1234-4215-5482-2451", "11/23",
                "123-25-4521", true);
            Subscription testTwo = new Subscription(Subscription.SubscriptionType.subscribedegree,
                    "Mick", "Jerry", "kerry184@purdue.edu", "fakeBassword123@",
                    "1234-4215-5482-2452", "12/23", "123-25-4521", true);
            ProgramUI uitest = new ProgramUI(new MockRepository(), new MockConsole());
        }
    }
}
