﻿
namespace Shem.AsyncEvents
{
    /// <summary>
    /// 
    /// </summary>
    public class DebugEvent : LogEvent
    {
        public DebugEvent()
        {

        }

        public override TorEvents Event
        {
            get { return TorEvents.DEBUG; }
        }
    }
}