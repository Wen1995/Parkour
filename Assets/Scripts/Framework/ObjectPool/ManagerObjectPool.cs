using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//对象池Manager，采用单例模式
public class ManagerObjectPool : MonoBehaviour {

    Dictionary<string, string> mDirMap = new Dictionary<string, string>();
    Dictionary<string, SubPool> mPoolMap = new Dictionary<string, SubPool>();
    ManagerObjectPool mInstance = null;                    //Singleton Ref

    public ManagerObjectPool Instance
    {
        get
        {
            return mInstance;
        }
    }

    /// <summary>
    /// 初始化对象池Manager,实例化单例
    /// </summary>
    public void Initialize()
    {
        if (mInstance != null)
            return;
        //TODO
        //1.实例化单例对象
        //2.读取资源路径，保存到DirMap
    }


    /// <summary>
    /// 注册对象池
    /// </summary>
    public void RegisterPool(string name, Transform transform)
    {
        //TODO
        //1. 从路径加载prefab
        //2. 创建pool，加入map
    }


    /// <summary>
    /// 取出对象
    /// </summary>
    public GameObject Spawn(string name)
    {
        if (mPoolMap.ContainsKey(name))
            return mPoolMap[name].Spawn();
        else
        {
            Debug.Log(name + "not exist in object pool");
            return null;
        }
    }

    /// <summary>
    /// 回收单个对象
    /// </summary>
    /// <param name="go"></param>
    public void UnSpawn(GameObject go)
    {
        if (mPoolMap.ContainsKey(go.name))
            mPoolMap[name].UnSpawn(go);
    }

    /// <summary>
    /// 回收该类型的所有对象
    /// </summary>
    /// <param name="name"></param>
    public void UnSpawnAll(string name)
    {
        if (mPoolMap.ContainsKey(name))
            mPoolMap[name].UnSpawnAll();
        else
            Debug.Log(name + "not exist in object pool");
    }
}
