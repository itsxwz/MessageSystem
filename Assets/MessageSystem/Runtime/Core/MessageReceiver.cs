using System;
using System.Collections.Generic;

namespace XR
{
    internal class MessageReceiver : IMessageReceiver
    {
        readonly MessageHolder messageHolder;

        Dictionary<string, Delegate> MessageNeedHandle => messageHolder.MessageNeedHandle;

        public MessageReceiver(MessageHolder messageHolder)
        {
            this.messageHolder = messageHolder;
        }

        public void Add(string key, Delegate handle)
        {
            if (!MessageNeedHandle.ContainsKey(key))
            {
                MessageNeedHandle.Add(key, handle);
            }
            else
            {
                MessageNeedHandle[key] = Delegate.Combine(MessageNeedHandle[key], handle);
            }
        }

        public void Remove(string key, Delegate handle)
        {
            if (MessageNeedHandle.ContainsKey(key))
            {
                MessageNeedHandle[key] = Delegate.Remove(MessageNeedHandle[key], handle);
                if (MessageNeedHandle[key] == null)
                {
                    MessageNeedHandle.Remove(key);
                }
            }
        }

        public void RemoveAll(string key)
        {
            if (MessageNeedHandle.ContainsKey(key))
            {
                MessageNeedHandle[key] = null;
                MessageNeedHandle.Remove(key);
            }
        }
    }
}