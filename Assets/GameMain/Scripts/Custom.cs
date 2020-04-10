using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.ObjectPool;

public class Custom : ObjectBase
{
    protected override void Release(bool isShutdown)
    {
        throw new System.NotImplementedException();
    }
}
