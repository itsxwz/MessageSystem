using System;

namespace UnityFramework.MessageSystem
{
    /// <summary>
    /// 消息接收者接口
    /// </summary>
    public interface IMessageReceiver
    {
        void Add(string key, Delegate handle);
        void Remove(string key, Delegate handle);
        void RemoveAll(string key);
    }
}