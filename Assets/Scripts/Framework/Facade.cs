using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoSingleton<Facade> {

    Controller mController;
    View mView;
    Model mModel;

    public void Initialize()
    {
        //初始化MVC三大类
        Controller.InitializeSingleton();
        mController = Controller.Instance;
        View.InitializeSingleton();
        mView = View.Instance;
    }

    //ui view------------------------------------------------
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

    public void SendEvent(string eventName, Object data)
    {
        mController.ExecuteEvent(eventName, data);
    }

    public void SendCommand(string name)
    {
        mController.ExecuteCommand(name);
    }
    //model------------------------------------------------

    //public T RetrieveModel<T>(string name)
    //    where T : Model
    //{
       
    //}
}
