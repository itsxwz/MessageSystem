using System;
using System.Collections.Generic;

namespace UnityFramework
{
    public class MessageSender : IMessageSender
    {
        MessageHolder holder;

        Dictionary<string, Delegate> NeedHandle
        {
            get { return holder.NeedHandle; }
        }

        public MessageSender(MessageHolder holder)
        {
            this.holder = holder;
        }

        public void SendMessage(IMessage iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                NeedHandle[iMessage.key].DynamicInvoke();
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }

        public void SendMessage<T>(IMessage<T> iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                var t = iMessage.GetType().GetProperty("t");
                var data = t.GetValue(iMessage, null);
                NeedHandle[iMessage.key].DynamicInvoke(data);
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }

        public void SendMessage<T1, T2>(IMessage<T1, T2> iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                var t1 = iMessage.GetType().GetProperty("t1");
                var t2 = iMessage.GetType().GetProperty("t2");
                var data1 = t1.GetValue(iMessage, null);
                var data2 = t2.GetValue(iMessage, null);
                NeedHandle[iMessage.key].DynamicInvoke(data1, data2);
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }

        public void SendMessage<T1, T2, T3>(IMessage<T1, T2, T3> iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                var t1 = iMessage.GetType().GetProperty("t1");
                var t2 = iMessage.GetType().GetProperty("t2");
                var t3 = iMessage.GetType().GetProperty("t3");
                var data1 = t1.GetValue(iMessage, null);
                var data2 = t2.GetValue(iMessage, null);
                var data3 = t3.GetValue(iMessage, null);
                NeedHandle[iMessage.key].DynamicInvoke(data1, data2, data3);
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }

        public void SendMessage<T1, T2, T3, T4>(IMessage<T1, T2, T3, T4> iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                var t1 = iMessage.GetType().GetProperty("t1");
                var t2 = iMessage.GetType().GetProperty("t2");
                var t3 = iMessage.GetType().GetProperty("t3");
                var t4 = iMessage.GetType().GetProperty("t4");
                var data1 = t1.GetValue(iMessage, null);
                var data2 = t2.GetValue(iMessage, null);
                var data3 = t3.GetValue(iMessage, null);
                var data4 = t4.GetValue(iMessage, null);
                NeedHandle[iMessage.key].DynamicInvoke(data1, data2, data3, data4);
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }

        public void SendMessage<T1, T2, T3, T4, T5>(IMessage<T1, T2, T3, T4, T5> iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                var t1 = iMessage.GetType().GetProperty("t1");
                var t2 = iMessage.GetType().GetProperty("t2");
                var t3 = iMessage.GetType().GetProperty("t3");
                var t4 = iMessage.GetType().GetProperty("t4");
                var t5 = iMessage.GetType().GetProperty("t5");
                var data1 = t1.GetValue(iMessage, null);
                var data2 = t2.GetValue(iMessage, null);
                var data3 = t3.GetValue(iMessage, null);
                var data4 = t4.GetValue(iMessage, null);
                var data5 = t5.GetValue(iMessage, null);
                NeedHandle[iMessage.key].DynamicInvoke(data1, data2, data3, data4, data5);
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }

        public void SendMessage<T1, T2, T3, T4, T5, T6>(IMessage<T1, T2, T3, T4, T5, T6> iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                var t1 = iMessage.GetType().GetProperty("t1");
                var t2 = iMessage.GetType().GetProperty("t2");
                var t3 = iMessage.GetType().GetProperty("t3");
                var t4 = iMessage.GetType().GetProperty("t4");
                var t5 = iMessage.GetType().GetProperty("t5");
                var t6 = iMessage.GetType().GetProperty("t6");
                var data1 = t1.GetValue(iMessage, null);
                var data2 = t2.GetValue(iMessage, null);
                var data3 = t3.GetValue(iMessage, null);
                var data4 = t4.GetValue(iMessage, null);
                var data5 = t5.GetValue(iMessage, null);
                var data6 = t6.GetValue(iMessage, null);
                NeedHandle[iMessage.key].DynamicInvoke(data1, data2, data3, data4, data5, data6);
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }

        public void SendMessage<T1, T2, T3, T4, T5, T6, T7>(IMessage<T1, T2, T3, T4, T5, T6, T7> iMessage)
        {
            if (NeedHandle.ContainsKey(iMessage.key))
            {
                var t1 = iMessage.GetType().GetProperty("t1");
                var t2 = iMessage.GetType().GetProperty("t2");
                var t3 = iMessage.GetType().GetProperty("t3");
                var t4 = iMessage.GetType().GetProperty("t4");
                var t5 = iMessage.GetType().GetProperty("t5");
                var t6 = iMessage.GetType().GetProperty("t6");
                var t7 = iMessage.GetType().GetProperty("t7");
                var data1 = t1.GetValue(iMessage, null);
                var data2 = t2.GetValue(iMessage, null);
                var data3 = t3.GetValue(iMessage, null);
                var data4 = t4.GetValue(iMessage, null);
                var data5 = t5.GetValue(iMessage, null);
                var data6 = t6.GetValue(iMessage, null);
                var data7 = t7.GetValue(iMessage, null);
                NeedHandle[iMessage.key].DynamicInvoke(data1, data2, data3, data4, data5, data6, data7);
            }
            else
            {
                holder.MessageNotHandled?.Invoke(iMessage);
            }
        }
    }
}