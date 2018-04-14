using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoSingleton<View> {
    Dictionary<string, PanelBase> panelMap;
    Dictionary<string, string> panelPathMap;

    public override void Initialize()
    {
        base.Initialize();

    }

    public void RegisterPanel()
    { }

    public void RemovePanel()
    { }
}
