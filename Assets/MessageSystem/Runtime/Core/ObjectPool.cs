using System;

namespace UnityFramework.MessageSystem
{
    /// <summary>
    /// 对象池
    /// </summary>
    /// <typeparam name="T">new()</typeparam>
    internal sealed class ObjectPool<T> where T : new()
    {
        private readonly int growSize = 20;

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

        /// <summary>
        /// 池容量
        /// </summary>
        public int Capacity => pool.Length;

        /// <summary>
        /// 可获取数量
        /// </summary>
        public int AvailableCount => pool.Length - nextIndex;

        /// <summary>
        /// 已分配数量
        /// </summary>
        public int AllocatedCount => nextIndex;

        /// <summary>
        /// 分配
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 回收
        /// </summary>
        /// <param name="t"></param>
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

        /// <summary>
        /// 重置
        /// </summary>
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