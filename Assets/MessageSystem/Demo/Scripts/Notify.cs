using UnityEngine;
using UnityEngine.SceneManagement;
using UnityFramework;

public class Notify : MonoBehaviour
{
    bool canSkip;

    void Awake()
    {
        canSkip = SceneManager.GetActiveScene().name == "Test1";
    }

    private void OnGUI()
    {
        /*
            消息分发即告诉所有相关事件绑定方：你们要做的什么什么事情(key)，可以做啦
        */

        if (GUILayout.Button("TurnRed"))
        {
            //无延迟单参数
            MessageManager.Get().Notify<Color>("turnRed", Color.red);
        }

        if (GUILayout.Button("Rot"))
        {
            //无延迟双参数
            MessageManager.Get().Notify<Quaternion, float>("rotate", Quaternion.identity, 3);
        }

        if (GUILayout.Button("Destroy"))
        {
            //无参带key
            MessageManager.Get().Notify("destroy");
        }

        if (GUILayout.Button("delyTurnBlue"))
        {
            //延迟单参数
            //请注意，谁开启的延迟分发消息，谁负责停止协程，而不是响应方；
            //注意发送和接收双方自身的存在周期，避免空引用
            MessageManager.Get().Notify<Color>("turnRed", this, Color.blue, 2);
        }

        if (GUILayout.Button("打印7个参数的消息"))
        {
            //无延迟七参数(目前最大参数数量)
            MessageManager.Get().Notify<int, int, int, int, int, int, int>("Test7Paras", 1, 2, 3, 4, 5, 6, 7);
        }

        if (GUILayout.Button("跳转到场景1"))
        {
            SceneManager.LoadScene("Test1");
        }

        if (GUILayout.Button("跳转到场景2"))
        {
            SceneManager.LoadScene("Test2");
        }
    }
}