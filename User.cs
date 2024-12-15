using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class User
    {
        public string Name { get; private set; }
        private IChatMediator _mediator;
        private List<string> _messageHistory; 

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            _messageHistory = new List<string>();
        }

        public void SendMessage(string message, string? recipientName = null)
        {
            if (string.IsNullOrEmpty(recipientName))
            {
                Console.WriteLine($"{Name} отправляет сообщение всем: {message}");
            }
            else
            {
                Console.WriteLine($"{Name} отправляет сообщение {recipientName}: {message}");
            }
            _mediator.SendMessage(message, this, recipientName);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            string fullMessage = $"От {senderName}: {message}";
            _messageHistory.Add(fullMessage);
            Console.WriteLine($"{Name} получил сообщение: {fullMessage}");
        }

        public void ShowMessageHistory()
        {
            Console.WriteLine($"История сообщений {Name}:");
            foreach (var message in _messageHistory)
            {
                Console.WriteLine(message);
            }
        }
    }
}
