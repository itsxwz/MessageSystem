using UnityEngine;
using UnityFramework;

public class Notify : MonoBehaviour
{
    MessageManager msgManater;

    private void Awake()
    {
        msgManater = MessageManager.Get();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("TurnRed"))
        {
            //无延迟单参数
            msgManater.Notify<Color>("turnRed", Color.red);
        }

        if (GUILayout.Button("Rot"))
        {
            //无延迟双参数
            msgManater.Notify<Quaternion, float>("rotate", Quaternion.identity, 3);
        }

        if (GUILayout.Button("Destroy"))
        {
            //无参带key
            msgManater.Notify("destroy");
        }

        if (GUILayout.Button("delyTurnBlue"))
        {
            //延迟单参数
            msgManater.Notify<Color>("turnRed", this, Color.blue, 2);
        }

        if (GUILayout.Button("打印7个参数的消息"))
        {
            //无延迟七参数(目前最大参数数量)
            msgManater.Notify<int, int, int, int, int, int, int>("Test7Paras", 1, 2, 3, 4, 5, 6, 7);
        }
    }
}