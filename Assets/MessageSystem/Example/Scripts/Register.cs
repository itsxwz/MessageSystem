using UnityEngine;

namespace UnityFramework.MessageSystem.Example
{
    public class Register : MonoBehaviour
    {
        MessageManager msgManager;

        void Start()
        {
            msgManager = MessageManager.Get();

            // Add/Remove时要指明类型，Notify时不需要
            //需要响应什么事件，就去绑定；需要处理什么逻辑，就去书写
            msgManager.Add<Color>("ChangeColor", ChangeColor);
            msgManager.Add<Quaternion, float>("ChangeQuaternion", ChangeQuaternion);
            msgManager.Add("Destroy", Destroy);
            msgManager.Add<int, int, int, int>("TestMaxParameters", TestMaxParameters);
        }

        private void OnDestroy()
        {
            //脚本行为结束时，注销所有注册的事件
            msgManager.Remove<Color>("ChangeColor", ChangeColor);
            msgManager.Remove<Quaternion, float>("ChangeQuaternion", ChangeQuaternion);
            msgManager.Remove("Destroy", Destroy);
            msgManager.Remove<int, int, int, int>("TestMaxParameters", TestMaxParameters);

            StopAllCoroutines();
        }

        void ChangeColor(Color color)
        {
            GetComponent<Renderer>().material.color = color;
        }

        void ChangeQuaternion(Quaternion rot, float time)
        {
            transform.rotation = rot;
        }

        void Destroy()
        {
            Destroy(gameObject);
        }

        void TestMaxParameters(int i1, int i2, int i3, int i4)
        {
            Debug.Log($"{i1} {i2} {i3} {i4}");
        }
    }
}