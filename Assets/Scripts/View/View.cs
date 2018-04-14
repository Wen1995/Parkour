using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoSingleton<View> {
    Dictionary<string, PanelBase> panelMap;
    Dictionary<string, string> panelPathMap;

    
    public void Initialize()
    {
        //TODO
        //加载资源路径
    }

    public void RegisterPanel()
    { }

    public void RemovePanel()
    { }
}
