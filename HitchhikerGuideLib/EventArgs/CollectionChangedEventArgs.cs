using System;

namespace HitchhikerGuide
{
    public class CollectionChangedEventArgs      : EventArgs
    {
        public CollectionChangedEventArgs(CollectionChangeReason reason)
        {
            Reason = reason;
        }

        public CollectionChangeReason Reason { get; }
    }
}