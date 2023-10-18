namespace UnityFramework.MessageSystem
{
    public delegate void V0();
    public delegate void V1<in T1>(T1 t1);
    public delegate void V2<in T1, in T2>(T1 t1, T2 t2);
    public delegate void V3<in T1, in T2, in T3>(T1 t1, T2 t2, T3 t3);
    public delegate void V4<in T1, in T2, in T3, in T4>(T1 t1, T2 t2, T3 t3, T4 t4);
}