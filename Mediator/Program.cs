
using Mediator.Chatrooms;
using Mediator.Participants;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator");

            var chat = new Chatroom();

            chat.Register(new Student("Adam"));
            chat.Register(new Student("Ewa"));
            chat.Register(new Student("Jolanta"));
            chat.Register(new Student("Mariusz"));
            chat.Register(new Teacher("Zygmunt"));
            chat.Register(new Teacher("Kornelia"));

            chat.Send("Adam", "Kornelia", "Jaki jest termin oddania projektu");
            chat.Send("Zygmunt", "Ewa", "Wyniki z kolowkium");
            chat.Send("Mariusz", "Jolanta", "Czy możesz pożyczyć notatki");
            chat.Send("Jolanta", "Mariusz", "Jasna sprawa");

            Console.ReadLine();
        }
    }
}
