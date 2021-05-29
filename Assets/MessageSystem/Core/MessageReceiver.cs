using System;
using System.Collections.Generic;

namespace UnityFramework
{
    public class MessageReceiver : IMessageReceiver
    {
        MessageHolder holder;

        Dictionary<string, Delegate> NeedHandle
        {
            get { return holder.NeedHandle; }
        }

        public MessageReceiver(MessageHolder holder)
        {
            this.holder = holder;
        }

        public void AddDelegate(string key, Delegate handle)
        {
            if (!NeedHandle.ContainsKey(key))
            {
                NeedHandle.Add(key, handle);
            }
            else
            {
                NeedHandle[key] = Delegate.Combine(NeedHandle[key], handle);
            }
        }

        public void RemoveDelegate(string key, Delegate handle)
        {
            if (NeedHandle.ContainsKey(key))
            {
                NeedHandle[key] = Delegate.Remove(NeedHandle[key], handle);
                if (NeedHandle[key] == null)
                {
                    NeedHandle.Remove(key);
                }
            }
        }

        public void RemoveAllDelegate(string key)
        {
            if (NeedHandle.ContainsKey(key))
            {
                NeedHandle.Remove(key);
            }
        }
    }
}