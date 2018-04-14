using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoSingleton<Controller> {

    Dictionary<string, Command> commandMap = new Dictionary<string, Command>();
    Dictionary<string, string> observerMap = new Dictionary<string, string>();

    public void RegisterCommand(string name, Command command)
    {
        if (commandMap.ContainsKey(name))
        {
            Debug.Log("this command has been registered");
            return;
        }
        commandMap.Add(name, command);

    }

    public void RemoveCommand()
    {

    }
}
