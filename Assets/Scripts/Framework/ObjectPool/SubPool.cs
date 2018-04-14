using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubPool : MonoBehaviour {

    List<GameObject> mObjects;

    GameObject mPrefab;
    Transform mParent;
    public string Name
    {
        get {
            return mPrefab.name;
        }
    }

    public SubPool(GameObject prefab, Transform transform)
    {
        mPrefab = prefab;
        mParent = transform;
    }


    //取出
    public GameObject Spawn()
    {
        GameObject go = null;
        foreach (var obj in mObjects)
        {
            if (!obj.activeSelf)
            {
                go = obj;
                break;
            }
        }
        //需要创建新对象
        if (go == null)
        {
            go = Instantiate<GameObject>(mPrefab);
            go.transform.parent = mParent;
            mObjects.Add(go);
        }

        go.SetActive(true);
        go.SendMessage("OnSpawn", SendMessageOptions.DontRequireReceiver);
        return go;
    }

    //回收
    public void UnSpawn(GameObject go)
    {
        if (mObjects.Contains(go))
        {
            go.SendMessage("OnUnSpawn", SendMessageOptions.DontRequireReceiver);
            go.SetActive(false);
        }
    }

    public void UnSpawnAll()
    {
        foreach (var obj in mObjects)
        {
            if (obj.activeSelf)
            {
                obj.SendMessage("OnUnSpawn", SendMessageOptions.DontRequireReceiver);
                obj.SetActive(false);
            }
        }
    }

}
