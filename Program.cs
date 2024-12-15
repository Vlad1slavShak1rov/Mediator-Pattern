using Mediator_Pattern;

ChatMediator chatMediator = new ChatMediator();

User user1 = new User("Gamer228", chatMediator);
User user2 = new User("Android", chatMediator);

chatMediator.AddUser(user1);
chatMediator.AddUser(user2);

user1.SendMessage("Привет мир");
user2.SendMessage("Привет, Gamer228", "Gamer228");
user2.SendMessage("Привет, Pavel", "Pavel");
Console.WriteLine();

user1.ShowMessageHistory();
user2.ShowMessageHistory();

Console.WriteLine();

chatMediator.RemoveUser(user2);
