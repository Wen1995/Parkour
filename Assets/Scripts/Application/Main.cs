using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//游戏入口类
public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // Initialize Singletom Class
        Facade.InitializeSingleton();
        ManagerScene.InitializeSingleton();
        

        ManagerScene.Instance.EnterScene(ConstVal.Scene_Lobby);
    }
	
}
