using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void EventCallBack(Object data = null);

public class Controller : MonoSingleton<Controller> {

    Dictionary<string, EventCallBack> mEventMap = new Dictionary<string, EventCallBack>();
    Dictionary<string, System.Type> mCommandMap = new Dictionary<string, System.Type>();

    public void Initialize()
    {
        //TODO
    }

    public void RegisterEvent(string eventName, EventCallBack callback)
    {
        if (mEventMap.ContainsKey(eventName))
            mEventMap[eventName] += callback;
        else
            mEventMap[eventName] = new EventCallBack(callback);
    }

    public void RemoveEvent(string eventName, EventCallBack callback)
    {
        if (mEventMap.ContainsKey(eventName))
            mEventMap[eventName] -= callback;
        else
            Debug.Log("Event Delegate Is Empty");
    }

    public void ExecuteEvent(string eventName, Object data = null)
    {
        if (mEventMap.ContainsKey(eventName))
            mEventMap[eventName](data);
        else
            Debug.Log("Event Delegate Is Empty");
    }

    public void RegisterCommand(string name, System.Type command)
    {
        if (!mCommandMap.ContainsKey(name))
        {
            mCommandMap[name] = command;
        }
        else
        {
            Debug.Log("Command{" + name + "} has been registered");
        }
    }

    public void ExecuteCommand(string name)
    {
        if (mCommandMap.ContainsKey(name))
        {
            Command command = System.Activator.CreateInstance(mCommandMap[name]) as Command;
            command.Execute();
        }
        else
        {
            Debug.Log("Command {" + name + "} is not registered");
        }
    }

}
