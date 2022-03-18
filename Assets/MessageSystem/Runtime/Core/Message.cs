namespace UnityFramework
{
    public class Message : IMessage
    {
        public string key { get; set; }

        private static ObjectPool<Message> pool = new ObjectPool<Message>(1, 1);

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

    public class Message<T> : IMessage<T>
    {
        public string key { get; set; }

        public T t { get; set; }

        private static ObjectPool<Message<T>> pool = new ObjectPool<Message<T>>(1, 1);

        public static Message<T> Allocate(string key, T t)
        {
            Message<T> msg = pool.Allocate();
            msg.key = key;
            msg.t = t;
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

        private static ObjectPool<Message<T1, T2>> pool = new ObjectPool<Message<T1, T2>>(1, 1);

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

        private static ObjectPool<Message<T1, T2, T3>> pool = new ObjectPool<Message<T1, T2, T3>>(1, 1);

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

        private static ObjectPool<Message<T1, T2, T3, T4>> pool = new ObjectPool<Message<T1, T2, T3, T4>>(1, 1);

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

    public class Message<T1, T2, T3, T4, T5> : IMessage<T1, T2, T3, T4, T5>
    {
        public string key { get; set; }

        public T1 t1 { get; set; }
        public T2 t2 { get; set; }
        public T3 t3 { get; set; }
        public T4 t4 { get; set; }
        public T5 t5 { get; set; }

        private static ObjectPool<Message<T1, T2, T3, T4, T5>> pool = new ObjectPool<Message<T1, T2, T3, T4, T5>>(1, 1);

        public static Message<T1, T2, T3, T4, T5> Allocate(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            Message<T1, T2, T3, T4, T5> msg = pool.Allocate();
            msg.key = key;
            msg.t1 = t1;
            msg.t2 = t2;
            msg.t3 = t3;
            msg.t4 = t4;
            msg.t5 = t5;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }

    public class Message<T1, T2, T3, T4, T5, T6> : IMessage<T1, T2, T3, T4, T5, T6>
    {
        public string key { get; set; }

        public T1 t1 { get; set; }
        public T2 t2 { get; set; }
        public T3 t3 { get; set; }
        public T4 t4 { get; set; }
        public T5 t5 { get; set; }
        public T6 t6 { get; set; }

        private static ObjectPool<Message<T1, T2, T3, T4, T5, T6>> pool = new ObjectPool<Message<T1, T2, T3, T4, T5, T6>>(1, 1);

        public static Message<T1, T2, T3, T4, T5, T6> Allocate(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        {
            Message<T1, T2, T3, T4, T5, T6> msg = pool.Allocate();
            msg.key = key;
            msg.t1 = t1;
            msg.t2 = t2;
            msg.t3 = t3;
            msg.t4 = t4;
            msg.t5 = t5;
            msg.t6 = t6;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }

    public class Message<T1, T2, T3, T4, T5, T6, T7> : IMessage<T1, T2, T3, T4, T5, T6, T7>
    {
        public string key { get; set; }

        public T1 t1 { get; set; }
        public T2 t2 { get; set; }
        public T3 t3 { get; set; }
        public T4 t4 { get; set; }
        public T5 t5 { get; set; }
        public T6 t6 { get; set; }
        public T7 t7 { get; set; }

        private static ObjectPool<Message<T1, T2, T3, T4, T5, T6, T7>> pool = new ObjectPool<Message<T1, T2, T3, T4, T5, T6, T7>>(1, 1);

        public static Message<T1, T2, T3, T4, T5, T6, T7> Allocate(string key, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        {
            Message<T1, T2, T3, T4, T5, T6, T7> msg = pool.Allocate();
            msg.key = key;
            msg.t1 = t1;
            msg.t2 = t2;
            msg.t3 = t3;
            msg.t4 = t4;
            msg.t5 = t5;
            msg.t6 = t6;
            msg.t7 = t7;
            return msg;
        }

        public void Release()
        {
            pool.Release(this);
        }
    }
}