using System.Collections.Generic;
using System;

namespace UnityFramework {
    public class MessageHolder
    {
        public Action<IMessage> MessageNotHandled;
        public Dictionary<string, Delegate> NeedHandle = new Dictionary<string, Delegate>();
    }
}