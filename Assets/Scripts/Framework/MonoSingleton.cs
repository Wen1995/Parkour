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
            if (mInstance == null)
            {
                Debug.Log("you need to instantiate a singleton class mannuly(by calling class.Initialize)");
                return null;
            }
            return mInstance;
        }
    }

    public virtual void Initialize()
    {
        GameObject go = new GameObject(typeof(T).Name);
        mInstance = go.AddComponent<T>();
        DontDestroyOnLoad(go);
    }
}
