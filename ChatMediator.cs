using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    
    public class ChatMediator : IChatMediator
    {
        private List<User> _users; 

        public ChatMediator()
        {
            _users = new List<User>();
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"{user.Name} присоединился к чату.");
        }

        public void RemoveUser(User user)
        {
            if (_users.Remove(user))
            {
                Console.WriteLine($"{user.Name} покинул чат.");
            }
        }

        public void SendMessage(string message, User sender, string? recipientName = null)
        {
            if (recipientName == null)
            {
                foreach (var user in _users)
                {
                    if (user != sender)
                    {
                        user.ReceiveMessage(message, sender.Name);
                    }
                }
            }
            else
            {
                var recipient = _users.Find(user => user.Name == recipientName);
                if (recipient != null)
                {
                    recipient.ReceiveMessage(message, sender.Name);
                }
                else
                {
                    Console.WriteLine($"Пользователь {recipientName} не найден в чате.");
                }
            }
        }
    }
}
