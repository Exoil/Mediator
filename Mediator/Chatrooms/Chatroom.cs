using Mediator.Participants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Chatrooms
{
    public abstract class AChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(string from, string to, string message);
    }

    public class Chatroom : AChatroom
    {
        private Dictionary<string, Participant> participantsDictonary;
        public string chatroomName {get;set;}
        public Chatroom()
        {
            chatroomName = "default name";
            participantsDictonary = new Dictionary<string, Participant>();
        }

        public override void Register(Participant participant)
        {
           if(!participantsDictonary.ContainsValue(participant))
           {
                participant.chatroom = this;
                participantsDictonary.Add(participant.name, participant);
           }

        }

        public override void Send(string from, string to, string message)
        {
            var participant = participantsDictonary[to];

            if(participant != null)
            {
                participant.Notify(from);
                participant.Recive(from, message);
            }
            else
            {
                Console.WriteLine($"Sorry, participant {to} doesn't exist in chatroom");
            }

        }
    }
}
