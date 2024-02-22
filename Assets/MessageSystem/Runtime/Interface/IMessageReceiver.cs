using System;

namespace XR
{
    public interface IMessageReceiver
    {
        void Add(string key, Delegate handle);
        void Remove(string key, Delegate handle);
        void RemoveAll(string key);
    }
}