using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoSingleton<Facade> {

    Controller mController;
    View mView;
    Model mModel;
    public void Initialize()
    {
        //初始化Model， View， Controller三个单例类

        //初始化三大类
    }

    //view------------------------------------------------
    public void RegisterPanel()
    { }

    public void RemovePanel()
    { }

    public void OpenPanel()
    { }

    public void ClosePanel()
    { }

    //controller-------------------------------------------
    public void RegisterEvent(string eventName, EventCallBack callback)
    {
        mController.RegisterEvent(eventName, callback);
    }

    public void RemoveEvent(string eventName, EventCallBack callback)
    {
        mController.RemoveEvent(eventName, callback);
    }

    public void SendEvent(string eventName)
    {
        mController.SendEvent(eventName);
    }
    //model------------------------------------------------


}
