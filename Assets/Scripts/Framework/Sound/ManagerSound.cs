using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSound : MonoBehaviour {

    AudioSource mSourceBG;
    AudioSource mSourceEffect;
    Dictionary<string, AudioClip> mClipMap;

    ManagerSound mInstance = null;                      //Singletom Ref

    public ManagerSound Instance
    {
        get
        {
            return mInstance;
        }
    }

    public void Initialized()
    {

        //TODO
        //1.初始化单例对象
        //2.加载资源

    }

    /// <summary>
    /// 播放bgm
    /// </summary>
    public void PlayBG(string name)
    {
        //判断是否已经在播放
        if (mSourceBG.clip.name == name)
            return;
        //判断是否存在
        if (!mClipMap.ContainsKey(name))
        {
            Debug.Log("clip[" + name + "] not exist");
            return;
        }
        AudioClip clip = mClipMap[name];
        mSourceBG.clip = clip;
        mSourceBG.Play();
    }

    /// <summary>
    /// 播放音效
    /// </summary>
    public void PlayerEffect(string name)
    {
        //判断是否存在
        if (!mClipMap.ContainsKey(name))
        {
            Debug.Log("clip[" + name + "] not exist");
            return;
        }
        AudioClip clip = mClipMap[name];
        mSourceEffect.PlayOneShot(clip);
    }
}
