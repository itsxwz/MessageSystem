using UnityEngine;
using System.Collections;

namespace XR
{
    public class MessageManager
    {
        private static MessageManager instance = default;
        private static readonly object locker = new object();

        public static MessageManager Get()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new MessageManager();
                    }
                }
            }

            return instance;
        }

        readonly MessageSender messageSender;
        readonly MessageReceiver messageReceiver;

        private MessageManager()
        {
            MessageHolder messageHolder = new MessageHolder();
            messageSender = new MessageSender(messageHolder);
            messageReceiver = new MessageReceiver(messageHolder);
        }

        public void Add(string key, V0 handle)
        {
            messageReceiver.Add(key, handle);
        }

        public void Remove(string key, V0 handle)
        {
            messageReceiver.Remove(key, handle);
        }

        public void Add<T1>(string key, V1<T1> handle)
        {
            messageReceiver.Add(key, handle);
        }

        public void Remove<T1>(string key, V1<T1> handle)
        {
            messageReceiver.Remove(key, handle);
        }

        public void Add<T1, T2>(string key, V2<T1, T2> handle)
        {
            messageReceiver.Add(key, handle);
        }

        public void Remove<T1, T2>(string key, V2<T1, T2> handle)
        {
            messageReceiver.Remove(key, handle);
        }

        public void Add<T1, T2, T3>(string key, V3<T1, T2, T3> handle)
        {
            messageReceiver.Add(key, handle);
        }

        public void Remove<T1, T2, T3>(string key, V3<T1, T2, T3> handle)
        {
            messageReceiver.Remove(key, handle);
        }

        public void Add<T1, T2, T3, T4>(string key, V4<T1, T2, T3, T4> handle)
        {
            messageReceiver.Add(key, handle);
        }

        public void Remove<T1, T2, T3, T4>(string key, V4<T1, T2, T3, T4> handle)
        {
            messageReceiver.Remove(key, handle);
        }

        public void RemoveAll(string key)
        {
            messageReceiver.RemoveAll(key);
        }

        public void Notify(string key)
        {
            Message message = Message.Allocate(key);
            messageSender.SendMessage(message);
            message.Release();
        }

        public IEnumerator DelayNotify(string key, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key);
        }

        public void Notify<T1>(string key, T1 t1)
        {
            Message<T1> message = Message<T1>.Allocate(key, t1);
            messageSender.SendMessage(message);
            message.Release();
        }

        public IEnumerator DelayNotify<T1>(string key, T1 t1, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1);
        }

        public void Notify<T1, T2>(string key, T1 t1, T2 t2)
        {
            Message<T1, T2> message = Message<T1, T2>.Allocate(key, t1, t2);
            messageSender.SendMessage(message);
            message.Release();
        }

        public IEnumerator DelayNotify<T1, T2>(string key, T1 t1, T2 t2, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2);
        }

        public void Notify<T1, T2, T3>(string key, T1 t1, T2 t2, T3 t3)
        {
            Message<T1, T2, T3> message = Message<T1, T2, T3>.Allocate(key, t1, t2, t3);
            messageSender.SendMessage(message);
            message.Release();
        }

        public IEnumerator DelayNotify<T1, T2, T3>(string key, T1 t1, T2 t2, T3 t3, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2, t3);
        }


        public void Notify<T1, T2, T3, T4>(string key, T1 t1, T2 t2, T3 t3, T4 t4)
        {
            Message<T1, T2, T3, T4> message = Message<T1, T2, T3, T4>.Allocate(key, t1, t2, t3, t4);
            messageSender.SendMessage(message);
            message.Release();
        }

        public IEnumerator DelayNotify<T1, T2, T3, T4>(string key, T1 t1, T2 t2, T3 t3, T4 t4, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2, t3, t4);
        }
    }
}