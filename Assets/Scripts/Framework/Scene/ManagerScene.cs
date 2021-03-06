﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoSingleton<ManagerScene>
{
    static Dictionary<string, int> mSceneMap = new Dictionary<string, int>();

    public void EnterScene(string name)
    {
        // call exit scene
        ExitScene(SceneManager.GetActiveScene().name);
        //enter new scene
        SceneManager.LoadScene(name);
        Facade.Instance.SendCommand(ConstVal.SceneEvent_EnterScene);
        //TODO
    }

    private void ExitScene(string name)
    {
        //TODO
        Debug.Log("exiting scene{" + name + "}");
    }
}
