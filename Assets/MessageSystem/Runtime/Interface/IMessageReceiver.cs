using System;

namespace XR
{
    internal interface IMessageReceiver
    {
        void Add(string key, Delegate handle);
        void Remove(string key, Delegate handle);
        void RemoveAll(string key);
    }
}