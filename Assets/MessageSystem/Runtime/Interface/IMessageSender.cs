namespace UnityFramework
{
    public interface IMessageSender
    {
        void SendMessage(IMessage iMessage);
        void SendMessage<T>(IMessage<T> iMessage);
        void SendMessage<T1, T2>(IMessage<T1, T2> rMessage);
        void SendMessage<T1, T2, T3>(IMessage<T1, T2, T3> rMessage);
        void SendMessage<T1, T2, T3, T4>(IMessage<T1, T2, T3, T4> rMessage);
        void SendMessage<T1, T2, T3, T4, T5>(IMessage<T1, T2, T3, T4, T5> iMessage);
        void SendMessage<T1, T2, T3, T4, T5, T6>(IMessage<T1, T2, T3, T4, T5, T6> iMessage);
        void SendMessage<T1, T2, T3, T4, T5, T6, T7>(IMessage<T1, T2, T3, T4, T5, T6, T7> iMessage);
    }
}