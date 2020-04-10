using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework.ObjectPool;
using System;

public class CustomPool : IObjectPool<Custom>
{
    public string Name => throw new NotImplementedException();

    public string FullName => throw new NotImplementedException();

    public Type ObjectType => throw new NotImplementedException();

    public int Count => throw new NotImplementedException();

    public int CanReleaseCount => throw new NotImplementedException();

    public bool AllowMultiSpawn => throw new NotImplementedException();

    public float AutoReleaseInterval { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Capacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public float ExpireTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool CanSpawn()
    {
        throw new NotImplementedException();
    }

    public bool CanSpawn(string name)
    {
        throw new NotImplementedException();
    }

    public void Register(Custom obj, bool spawned)
    {
        throw new NotImplementedException();
    }

    public void Release()
    {
        throw new NotImplementedException();
    }

    public void Release(int toReleaseCount)
    {
        throw new NotImplementedException();
    }

    public void Release(ReleaseObjectFilterCallback<Custom> releaseObjectFilterCallback)
    {
        throw new NotImplementedException();
    }

    public void Release(int toReleaseCount, ReleaseObjectFilterCallback<Custom> releaseObjectFilterCallback)
    {
        throw new NotImplementedException();
    }

    public void ReleaseAllUnused()
    {
        throw new NotImplementedException();
    }

    public void SetLocked(Custom obj, bool locked)
    {
        throw new NotImplementedException();
    }

    public void SetLocked(object target, bool locked)
    {
        throw new NotImplementedException();
    }

    public void SetPriority(Custom obj, int priority)
    {
        throw new NotImplementedException();
    }

    public void SetPriority(object target, int priority)
    {
        throw new NotImplementedException();
    }

    public Custom Spawn()
    {
        throw new NotImplementedException();
    }

    public Custom Spawn(string name)
    {
        throw new NotImplementedException();
    }

    public void Unspawn(Custom obj)
    {
        throw new NotImplementedException();
    }

    public void Unspawn(object target)
    {
        throw new NotImplementedException();
    }
}
