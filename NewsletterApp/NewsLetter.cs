using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsletterApp
{
    abstract class NewsLetter
    {
        private int _mailNumber;
        private List<ISubscriber> _observers = new List<ISubscriber>();

        public int MailNumber { get => _mailNumber; set { if (_mailNumber != value) { _mailNumber = value; Notify(); } } }

        public NewsLetter(int mailNumber)
        {
            _mailNumber = mailNumber;
        }

        public void Attach(ISubscriber observer)
        {
            _observers.Add(observer);
        }

        public void Detach(ISubscriber observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
            Console.WriteLine();
        }
    }

    interface ISubscriber
    {
        void Update(NewsLetter newsLetter);
    }

    class Subscriber : ISubscriber
    {
        public readonly string Name;

        private NewsLetter _newsLetter;

        public Subscriber(string name, NewsLetter newsLetter)
        {
            Name = name;
            _newsLetter = newsLetter;
        }

        public void Update(NewsLetter newsLetter)
        {
            Console.WriteLine($"Subscriber {Name} got a new mail to read. Mail code {newsLetter.MailNumber}");
        }
    }

    class IKEANewsletter : NewsLetter
    {
        public IKEANewsletter(int mailNumber) : base(mailNumber)
        {
            
        }
    }
}
