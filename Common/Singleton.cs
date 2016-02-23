// シングルトン

using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = (T)FindObjectOfType(typeof(T));
                if (instance == null) Debug.LogError("SingletonError : " + typeof(T) + "をScene内に配置してください。");
            }
            return instance;
        }
    }
}
