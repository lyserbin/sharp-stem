﻿using Shem.Replies;

namespace Shem.AsyncEvents
{
    public class DescChangedEvent : AsyncEvent
    {
        public DescChangedEvent()
        {

        }

        public override AsyncEvents Event
        {
            get { return AsyncEvents.DESCCHANGED; }
        }

        protected override void ParseToEvent(Reply reply)
        {
            //TODO: Implement parsing
            throw new System.NotImplementedException();
        }

        public override string RawString
        {
            get { throw new System.NotImplementedException(); }
        }

        public override string EventLine
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}