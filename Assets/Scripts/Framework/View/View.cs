using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoSingleton<View> {


    Dictionary<string, PanelBase> mPanelMap = new Dictionary<string, PanelBase>();

    //panel
    public void OverlayerPanel(string name)
    {
        //TODO
    }

    public void BackPanel()
    {
        //TODO
    }

    //
}
