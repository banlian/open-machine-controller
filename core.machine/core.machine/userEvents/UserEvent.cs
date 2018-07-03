using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.machine.userEvents
{
    public class UserEvent
    {
        public UserEventType EventType;

        public object Sender;

        public IUserEventHandler Target;

        public object EventData;
    }


    public enum UserEventType
    {

        Start,
        Pause,
        Continue,
        Stop,
        Reset,

        UserAction,
    }

    public interface IUserEventHandler
    {
        void HandleEvent(UserEvent userEvent);

    }

}
