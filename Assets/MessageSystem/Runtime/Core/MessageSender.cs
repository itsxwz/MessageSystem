using System;
using System.Collections.Generic;

namespace UnityFramework.MessageSystem
{
    /// <summary>
    /// 消息发送者
    /// </summary>
    public class MessageSender : IMessageSender
    {
        readonly MessageHolder messageHolder;

        Dictionary<string, Delegate> MessageNeedHandle => messageHolder.MessageNeedHandle;

        public MessageSender(MessageHolder messageHolder)
        {
            this.messageHolder = messageHolder;
        }

        public void SendMessage(IMessage message)
        {
            if (MessageNeedHandle.TryGetValue(message.key, out var del))
            {
                del?.DynamicInvoke();
            }
            else
            {
                messageHolder.MessageNotHandle?.Invoke(message);
            }
        }

        public void SendMessage<T1>(IMessage<T1> message)
        {
            if (MessageNeedHandle.TryGetValue(message.key, out var del))
            {
                var t1 = message.GetType().GetProperty("t1");
                
                var data = t1?.GetValue(message, null);
                del?.DynamicInvoke(data);
            }
            else
            {
                messageHolder.MessageNotHandle?.Invoke(message);
            }
        }

        public void SendMessage<T1, T2>(IMessage<T1, T2> message)
        {
            if (MessageNeedHandle.TryGetValue(message.key, out var del))
            {
                var t1 = message.GetType().GetProperty("t1");
                var t2 = message.GetType().GetProperty("t2");
                
                var data1 = t1?.GetValue(message, null);
                var data2 = t2?.GetValue(message, null);
                del?.DynamicInvoke(data1, data2);
            }
            else
            {
                messageHolder.MessageNotHandle?.Invoke(message);
            }
        }

        public void SendMessage<T1, T2, T3>(IMessage<T1, T2, T3> message)
        {
            if (MessageNeedHandle.TryGetValue(message.key, out var del))
            {
                var t1 = message.GetType().GetProperty("t1");
                var t2 = message.GetType().GetProperty("t2");
                var t3 = message.GetType().GetProperty("t3");
                
                var data1 = t1?.GetValue(message, null);
                var data2 = t2?.GetValue(message, null);
                var data3 = t3?.GetValue(message, null);
                del.DynamicInvoke(data1, data2, data3);
            }
            else
            {
                messageHolder.MessageNotHandle?.Invoke(message);
            }
        }

        public void SendMessage<T1, T2, T3, T4>(IMessage<T1, T2, T3, T4> message)
        {
            if (MessageNeedHandle.TryGetValue(message.key, out var value))
            {
                var t1 = message.GetType().GetProperty("t1");
                var t2 = message.GetType().GetProperty("t2");
                var t3 = message.GetType().GetProperty("t3");
                var t4 = message.GetType().GetProperty("t4");
                
                var data1 = t1?.GetValue(message, null);
                var data2 = t2?.GetValue(message, null);
                var data3 = t3?.GetValue(message, null);
                var data4 = t4?.GetValue(message, null);
                value.DynamicInvoke(data1, data2, data3, data4);
            }
            else
            {
                messageHolder.MessageNotHandle?.Invoke(message);
            }
        }
    }
}