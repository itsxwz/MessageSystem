using System;
using UnityEngine;
using UnityFramework;

/// <summary>
/// 注冊就可以接受廣播了。
/// </summary>
public class Register : MonoBehaviour
{
    MessageManager msgManater;

    void Start()
    {
        msgManater = MessageManager.Get();

        msgManater.AddListener<Color>("turnRed", OnReceive);
        msgManater.AddListener<Quaternion, float>("rotate", OnReceive);
        msgManater.AddListener("destroy", Destroy);
        msgManater.AddListener<int,int,int,int,int,int,int>("Test7Paras", Print7Paras);
    }

    private void OnDestroy()
    {
        msgManater.RemoveListener<Color>("turnRed", OnReceive);
        msgManater.RemoveListener<Quaternion, float>("rotate", OnReceive);
        msgManater.RemoveListener("destroy", Destroy);
        msgManater.RemoveListener<int,int,int,int,int,int,int>("Test7Paras", Print7Paras);
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