namespace XR
{
    public interface IMessageSender
    {
        void SendMessage(IMessage mes);
        void SendMessage<T1>(IMessage<T1> message);
        void SendMessage<T1, T2>(IMessage<T1, T2> message);
        void SendMessage<T1, T2, T3>(IMessage<T1, T2, T3> message);
        void SendMessage<T1, T2, T3, T4>(IMessage<T1, T2, T3, T4> message);
    }
}