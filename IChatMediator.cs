using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public interface IChatMediator
    {
        void AddUser(User user); 
        void RemoveUser(User user); 
        void SendMessage(string message, User sender, string? recipientName = null); 
    }
}
