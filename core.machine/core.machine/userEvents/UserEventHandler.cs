using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.machine.userEvents
{

    public enum HandlerState
    {
        Ready,
        Handling,
        Pause,
        HandlingSuccess,
        HandlingFail,
    }

    public abstract class UserEventHandler : IUserEventHandler

    {
        public void HandleEvent(UserEvent userEvent)
        {
            switch (userEvent.EventType)
            {
                case UserEventType.Start:
                    OnStartEvent();
                    break;
                case UserEventType.Stop:
                    OnStopEvent();
                    break;
                case UserEventType.Pause:
                    OnPauseEvent();
                    break;
                case UserEventType.Continue:
                    OnContinueEvent();
                    break;

                case UserEventType.Reset:
                    OnResetEvent();
                    break;

                case UserEventType.UserAction:
                    OnUserActionEvent();
                    break;
            }


        }

        protected virtual void OnStartEvent()
        {
            
        }

        protected virtual void OnPauseEvent()
        {
            
        }

        protected virtual void OnContinueEvent()
        {
            
        }

        protected virtual void OnStopEvent()
        {
            
        }
        protected virtual void OnResetEvent()
        {
            
        }

        protected virtual void OnUserActionEvent()
        {
            
        }

    }
}
