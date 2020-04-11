using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsletterApp
{
    class ObserverSample
    {
        public static void Demo()
        {
            var ikea = new IKEANewsletter(12312);

            var user1 = new Subscriber("Thanos", ikea );
            var user2 = new Subscriber("Anna", ikea );
            var user3 = new Subscriber("Dimitra", ikea );

            ikea.Attach(user1);
            ikea.Attach(user2);

            ikea.MailNumber = 54355;
            ikea.MailNumber = 84388;

            ikea.Detach(user1);

            ikea.MailNumber = 78855;

            ikea.Attach(user3);
            ikea.MailNumber = 00355;
            ikea.MailNumber = 32322;

            ikea.Detach(user2);

            ikea.MailNumber = 12344;
        }
    }
}
