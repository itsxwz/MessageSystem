namespace XR
{
    public interface IMessage
    {
        string key { get; set; }
        void Release();
    }

    public interface IMessage<T1> : IMessage
    {
        T1 t1 { get; set; }
    }

    public interface IMessage<T1, T2> : IMessage
    {
        T1 t1 { get; set; }
        T2 t2 { get; set; }
    }

    public interface IMessage<T1, T2, T3> : IMessage
    {
        T1 t1 { get; set; }
        T2 t2 { get; set; }
        T3 t3 { get; set; }
    }

    public interface IMessage<T1, T2, T3, T4> : IMessage
    {
        T1 t1 { get; set; }
        T2 t2 { get; set; }
        T3 t3 { get; set; }
        T4 t4 { get; set; }
    }
}