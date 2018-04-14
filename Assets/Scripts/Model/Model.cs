using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour {

    Dictionary<string, PackageBase> mPackageBaseList = new Dictionary<string, PackageBase>();

    public void Initialize()
    {
    }



    public void RegisterPackageBase(string name)
    {
        //
    }

    public PackageBase RetrievePackageBase(string name)
    {
        if (mPackageBaseList.ContainsKey(name))
        {
            return mPackageBaseList[name];
        }
        else
        {
            Debug.Log("PackageBase{" + name + "} not exist");
            return null;
        }
    }
}
