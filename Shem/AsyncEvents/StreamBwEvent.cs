﻿using Shem.Replies;

namespace Shem.AsyncEvents
{
    public class StreamBwEvent : AsyncEvent
    {
        public StreamBwEvent()
        {

        }

        public override AsyncEvents Event
        {
            get { return AsyncEvents.STREAM_BW; }
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