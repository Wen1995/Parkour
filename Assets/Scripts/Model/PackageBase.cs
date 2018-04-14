using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageBase : MonoBehaviour {

    string name;

    public string Name
    {
        get
        {
            return name;
        }
    }

    protected void SendEvent()
    {
        //TODO
    }
}
