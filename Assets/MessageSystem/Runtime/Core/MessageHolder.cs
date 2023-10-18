using System.Collections.Generic;
using System;

namespace UnityFramework.MessageSystem
{
    /// <summary>
    /// 消息持有者
    /// </summary>
    public class MessageHolder
    {
        public readonly Action<IMessage> MessageNotHandle = default;
        public readonly Dictionary<string, Delegate> MessageNeedHandle = new Dictionary<string, Delegate>();
    }
}