using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void EventCallBack(Object data = null);

public class Controller : MonoSingleton<Controller> {

    Dictionary<string, EventCallBack> eventMap = new Dictionary<string, EventCallBack>();
    public void Initialize()
    {
        //TODO
    }

    public void RegisterEvent(string eventName, EventCallBack callback)
    {
        if (eventMap.ContainsKey(eventName))
            eventMap[eventName] += callback;
        else
            eventMap[eventName] = new EventCallBack(callback);
    }

    public void RemoveEvent(string eventName, EventCallBack callback)
    {
        if (eventMap.ContainsKey(eventName))
            eventMap[eventName] -= callback;
        else
            Debug.Log("Event Delegate Is Empty");
    }

    public void SendEvent(string eventName)
    {
        if (eventMap.ContainsKey(eventName))
            eventMap[eventName]();
        else
            Debug.Log("Event Delegate Is Empty");
    }
}
