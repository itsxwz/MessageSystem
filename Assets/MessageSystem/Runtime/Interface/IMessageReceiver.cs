using System;

namespace UnityFramework {
    public interface IMessageReceiver
    {
        void AddDelegate(string key, Delegate handle);
        void RemoveDelegate(string key, Delegate handle);
        void RemoveAllDelegate(string key);
    }
}