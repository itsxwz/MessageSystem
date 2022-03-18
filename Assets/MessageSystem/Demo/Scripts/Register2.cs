using UnityEngine;
using UnityFramework;

public class Register2 : MonoBehaviour
{
    MessageManager msgManager;

    void Start()
    {
        msgManager = MessageManager.Get();

        //需要响应什么事件，就去绑定；需要处理什么逻辑，就去书写
        msgManager.AddListener<Color>("turnRed", OnReceive);
        msgManager.AddListener<Quaternion, float>("rotate", OnReceive);
        msgManager.AddListener("destroy", Destroy);
        msgManager.AddListener<int,int,int,int,int,int,int>("Test7Paras", Print7Paras);
    }

    private void OnDestroy()
    {
        //脚本行为结束时，注销所有注册的事件
        msgManager.RemoveListener<Color>("turnRed", OnReceive);
        msgManager.RemoveListener<Quaternion, float>("rotate", OnReceive);
        msgManager.RemoveListener("destroy", Destroy);
        msgManager.RemoveListener<int,int,int,int,int,int,int>("Test7Paras", Print7Paras);
        StopAllCoroutines();
    }

    void OnReceive(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }

    void OnReceive(Quaternion rot, float time)
    {
        Debug.Log(time);
        transform.rotation = rot;
    }

    void Destroy()
    {
        Destroy(gameObject);
    }

    void Print7Paras(int i1, int i2, int i3, int i4, int i5, int i6, int i7)
    {
        Debug.Log($"{i1} {i2} {i3} {i4} {i5} {i6} {i7}");
    }
}