using System.Collections;
using System.Collections.Generic;

//对象池取出与回收操作接口
public interface InterfacePool{
    //取出
    void OnSpawn();
    //回收
    void OnUnSpawn();
}
