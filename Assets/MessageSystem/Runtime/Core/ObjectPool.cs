using System;

namespace UnityFramework
{
    public sealed class ObjectPool<T>
        where T : new()
    {
        private int growSize = 20;

        private T[] pool;

        private int nextIndex = 0;

        public ObjectPool(int size)
        {
            Resize(size, false);
        }

        public ObjectPool(int size, int growSize)
        {
            this.growSize = growSize;

            Resize(size, false);
        }
        
        public int Length
        {
            get { return pool.Length; }
        }
        
        public int Available
        {
            get { return pool.Length - nextIndex; }
        }
        
        public int Allocated
        {
            get { return nextIndex; }
        }

        public T Allocate()
        {
            T t = default(T);
            
            if (nextIndex >= pool.Length)
            {
                if (growSize > 0)
                {
                    Resize(pool.Length + growSize, true);
                }
                else
                {
                    return t;
                }
            }
            
            if (nextIndex >= 0 && nextIndex < pool.Length)
            {
                t = pool[nextIndex];
                nextIndex++;
            }

            return t;
        }

        public void Release(T t)
        {
            if (t == null)
            {
                return;
            }
            
            if (nextIndex > 0)
            {
                nextIndex--;
                pool[nextIndex] = t;
            }
        }

        public void Reset()
        {
            int len = growSize;
            if (pool != null)
            {
                len = pool.Length;
            }

            Resize(len, false);
            nextIndex = 0;
        }

        private void Resize(int size, bool copyExisting)
        {
            lock (this)
            {
                int count = 0;

                T[] newPool = new T[size];

                if (pool != null && copyExisting)
                {
                    count = pool.Length;
                    Array.Copy(pool, newPool, Math.Min(count, size));
                }
                
                for (int i = count; i < size; i++)
                {
                    newPool[i] = new T();
                }

                pool = newPool;
            }
        }
    }
}