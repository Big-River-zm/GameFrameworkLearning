using GameFramework.ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZZ.Custom
{
    public class CustomObject:ObjectBase
    {
        public CustomObject(GameObject gameObject, string name)
        {
            Initialize(name, gameObject);
        }

        protected override void OnSpawn()
        {
            base.OnSpawn();
            Debug.Log("获取到了" + Name);
        }

        protected override void OnUnspawn()
        {
            base.OnUnspawn();
            Debug.Log("回收了" + Name);
        }

        protected override void Release(bool isShutdown)
        {
            Debug.Log("Release:" + Name);
        }
    }
}

