using System.Collections.Generic;
using System;

namespace XR
{
    public class MessageHolder
    {
        public readonly Action<IMessage> MessageNotHandle = default;
        public readonly Dictionary<string, Delegate> MessageNeedHandle = new Dictionary<string, Delegate>();
    }
}