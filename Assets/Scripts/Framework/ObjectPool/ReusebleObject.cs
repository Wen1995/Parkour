using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//被对象池管理的对象
public abstract class ReusebleObject : MonoBehaviour, InterfacePool{

    public abstract void OnSpawn();

    public abstract void OnUnSpawn();
}
