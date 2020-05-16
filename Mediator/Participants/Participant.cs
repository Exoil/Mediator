using Mediator.Chatrooms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mediator.Participants
{
    public abstract class Participant
    {
        public string name { get; set; }
        public AChatroom chatroom { get; set; }
        
        public void Send(string to, string message)
        {
            chatroom.Send(name, to, message);
        }

        public Participant(string name)
        {
            this.name = name;
        }

        public abstract void Recive(string from, string message);

        public abstract void Notify(string from);

    }


    public class Student : Participant
    {
        public Student(string name) : base(name)
        {

        }
        public override void Notify(string from)
        {
            Console.WriteLine($"You Student {name} get a message from {from}");
        }

        public override void Recive(string from, string message)
        {
            Console.WriteLine($"{from}: {message}");
        }
    }

    public class Teacher : Participant
    {

        public Teacher(string name) :base(name)
        {

        }
        public override void Notify(string from)
        {
            Console.WriteLine($"You  Teacher {name} get a message from {from}");
        }

        public override void Recive(string from, string message)
        {
            Console.WriteLine($"{from}: {message}");
        }
    }
}
