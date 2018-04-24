using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour
where T:MonoBehaviour{

    static T mInstance = null;

    public static T Instance
    {
        get
        {
            return mInstance;
        }
    }

    public static void InitializeSingleton()
    {
        if (Instance != null)
        {
            Debug.Log("SingleTon has been initialized");
        }
        GameObject go = new GameObject(typeof(T).Name);
        mInstance = go.AddComponent<T>();
        DontDestroyOnLoad(go);
        go.SendMessage("Initialize",SendMessageOptions.DontRequireReceiver);
    }
}
