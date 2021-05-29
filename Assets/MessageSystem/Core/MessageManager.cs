using UnityEngine;
using System.Collections;

namespace UnityFramework
{
    public class MessageManager
    {
        private static MessageManager instance = default;
        private static object locker = new object();
        private static bool isQuit = false;

        public static MessageManager Get()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null && !isQuit)
                    {
                        instance = new MessageManager();
                    }
                }
            }

            return instance;
        }

        MessageHolder holder;
        MessageSender sender;
        MessageReceiver receiver;

        private MessageManager()
        {
            holder = new MessageHolder();
            sender = new MessageSender(holder);
            receiver = new MessageReceiver(holder);
        }

        public void AddListener(string key, V0 handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener(string key, V0 handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void AddListener<T>(string key, V1<T> handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener<T>(string key, V1<T> handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void AddListener<T1, T2>(string key, V2<T1, T2> handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener<T1, T2>(string key, V2<T1, T2> handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void AddListener<T1, T2, T3>(string key, V3<T1, T2, T3> handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener<T1, T2, T3>(string key, V3<T1, T2, T3> handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void AddListener<T1, T2, T3, T4>(string key, V4<T1, T2, T3, T4> handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener<T1, T2, T3, T4>(string key, V4<T1, T2, T3, T4> handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void AddListener<T1, T2, T3, T4, T5>(string key, V5<T1, T2, T3, T4, T5> handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener<T1, T2, T3, T4, T5>(string key, V5<T1, T2, T3, T4, T5> handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void AddListener<T1, T2, T3, T4, T5, T6>(string key, V6<T1, T2, T3, T4, T5, T6> handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener<T1, T2, T3, T4, T5, T6>(string key, V6<T1, T2, T3, T4, T5, T6> handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void AddListener<T1, T2, T3, T4, T5, T6, T7>(string key, V7<T1, T2, T3, T4, T5, T6, T7> handle)
        {
            receiver.AddDelegate(key, handle);
        }

        public void RemoveListener<T1, T2, T3, T4, T5, T6, T7>(string key, V7<T1, T2, T3, T4, T5, T6, T7> handle)
        {
            receiver.RemoveDelegate(key, handle);
        }

        public void RemoveAllListener(string key)
        {
            receiver.RemoveAllDelegate(key);
        }

        public void Notify(string key)
        {
            Message message = Message.Allocate(key);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify(string key, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key);
        }

        public void Notify(string key, MonoBehaviour mono, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, delay));
        }

        public void Notify<T>(string key, T t)
        {
            Message<T> message = Message<T>.Allocate(key, t);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify<T>(string key, T t1, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1);
        }

        public void Notify<T>(string key, MonoBehaviour mono, T t1, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, t1, delay));
        }

        public void Notify<T1, T2>(string key, T1 t1, T2 t2)
        {
            Message<T1, T2> message = Message<T1, T2>.Allocate(key, t1, t2);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify<T1, T2>(string key, T1 t1, T2 t2, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2);
        }

        public void Notify<T1, T2>(string key, MonoBehaviour mono, T1 t1, T2 t2, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, t1, t2, delay));
        }

        public void Notify<T1, T2, T3>(string key, T1 t1, T2 t2, T3 t3)
        {
            Message<T1, T2, T3> message = Message<T1, T2, T3>.Allocate(key, t1, t2, t3);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify<T1, T2, T3>(string key, T1 t1, T2 t2, T3 t3, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2, t3);
        }

        public void Notify<T1, T2, T3>(string key, MonoBehaviour mono, T1 t1, T2 t2, T3 t3, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, t1, t2, t3, delay));
        }

        public void Notify<T1, T2, T3, T4>(string key, T1 t1, T2 t2, T3 t3, T4 t4)
        {
            Message<T1, T2, T3, T4> message = Message<T1, T2, T3, T4>.Allocate(key, t1, t2, t3, t4);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify<T1, T2, T3, T4>(string key, T1 t1, T2 t2, T3 t3, T4 t4, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2, t3, t4);
        }

        public void Notify<T1, T2, T3, T4>(string key, MonoBehaviour mono, T1 t1, T2 t2, T3 t3, T4 t4, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, t1, t2, t3, t4, delay));
        }

        public void Notify<T1, T2, T3, T4, T5>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            Message<T1, T2, T3, T4, T5> message = Message<T1, T2, T3, T4, T5>.Allocate(key, t1, t2, t3, t4, t5);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify<T1, T2, T3, T4, T5>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2, t3, t4, t5);
        }

        public void Notify<T1, T2, T3, T4, T5>(string key, MonoBehaviour mono, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, t1, t2, t3, t4, t5, delay));
        }

        public void Notify<T1, T2, T3, T4, T5, T6>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            Message<T1, T2, T3, T4, T5, T6> message = Message<T1, T2, T3, T4, T5, T6>.Allocate(key, t1, t2, t3, t4, t5, t6);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify<T1, T2, T3, T4, T5, T6>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2, t3, t4, t5, t6);
        }

        public void Notify<T1, T2, T3, T4, T5, T6>(string key, MonoBehaviour mono, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, t1, t2, t3, t4, t5, t6, delay));
        }

        public void Notify<T1, T2, T3, T4, T5, T6, T7>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            Message<T1, T2, T3, T4, T5, T6, T7> message = Message<T1, T2, T3, T4, T5, T6, T7>.Allocate(key, t1, t2, t3, t4, t5, t6, t7);
            sender.SendMessage(message);
            message.Release();
        }

        IEnumerator DelayNotify<T1, T2, T3, T4, T5, T6, T7>(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, float delay)
        {
            yield return new WaitForSeconds(delay);
            Notify(key, t1, t2, t3, t4, t5, t6, t7);
        }

        public void Notify<T1, T2, T3, T4, T5, T6, T7>(string key, MonoBehaviour mono, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, float delay)
        {
            mono.StartCoroutine(DelayNotify(key, t1, t2, t3, t4, t5, t6, t7, delay));
        }
    }
}