namespace UnityFramework.MessageSystem
{
    public class Message : IMessage
    {
        public string key { get; set; }

        private static readonly ObjectPool<Message> pool = new ObjectPool<Message>(1, 1);

        public static Message Allocate(string key)
        {
            Message msg = pool.Allocate();
            msg.key = key;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }

    public class Message<T1> : IMessage<T1>
    {
        public string key { get; set; }

        public T1 t1 { get; set; }

        private static readonly ObjectPool<Message<T1>> pool = new ObjectPool<Message<T1>>(1, 1);

        public static Message<T1> Allocate(string key, T1 t1)
        {
            Message<T1> msg = pool.Allocate();
            msg.key = key;
            msg.t1 = t1;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }

    public class Message<T1, T2> : IMessage<T1, T2>
    {
        public string key { get; set; }

        public T1 t1 { get; set; }
        public T2 t2 { get; set; }

        private static readonly ObjectPool<Message<T1, T2>> pool = new ObjectPool<Message<T1, T2>>(1, 1);

        public static Message<T1, T2> Allocate(string key, T1 t1, T2 t2)
        {
            Message<T1, T2> msg = pool.Allocate();
            msg.key = key;
            msg.t1 = t1;
            msg.t2 = t2;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }

    public class Message<T1, T2, T3> : IMessage<T1, T2, T3>
    {
        public string key { get; set; }

        public T1 t1 { get; set; }
        public T2 t2 { get; set; }
        public T3 t3 { get; set; }

        private static readonly ObjectPool<Message<T1, T2, T3>> pool = new ObjectPool<Message<T1, T2, T3>>(1, 1);

        public static Message<T1, T2, T3> Allocate(string key, T1 t1, T2 t2, T3 t3)
        {
            Message<T1, T2, T3> msg = pool.Allocate();
            msg.key = key;
            msg.t1 = t1;
            msg.t2 = t2;
            msg.t3 = t3;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }

    public class Message<T1, T2, T3, T4> : IMessage<T1, T2, T3, T4>
    {
        public string key { get; set; }

        public T1 t1 { get; set; }
        public T2 t2 { get; set; }
        public T3 t3 { get; set; }
        public T4 t4 { get; set; }

        private static readonly ObjectPool<Message<T1, T2, T3, T4>> pool = new ObjectPool<Message<T1, T2, T3, T4>>(1, 1);

        public static Message<T1, T2, T3, T4> Allocate(string key, T1 t1, T2 t2, T3 t3, T4 t4)
        {
            Message<T1, T2, T3, T4> msg = pool.Allocate();
            msg.key = key;
            msg.t1 = t1;
            msg.t2 = t2;
            msg.t3 = t3;
            msg.t4 = t4;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }
}