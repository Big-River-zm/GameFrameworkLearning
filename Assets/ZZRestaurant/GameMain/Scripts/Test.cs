using GameFramework.ObjectPool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZZ.Core;
using ZZ.Custom;

public class Test : MonoBehaviour
{
    public GameObject prefabCustomGo;
    private IObjectPool<CustomObject> customObjectPool;
    public Transform TextContain;

    private void Start()
    {
        customObjectPool = GameEntry.ObjectPool.CreateMultiSpawnObjectPool<CustomObject>(10,5f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine("SpawnCustom");
        }
    }

    private void RegisterCustom()
    {
        CustomObject customObject = new CustomObject(prefabCustomGo, "Custom");
        customObjectPool.Register(customObject, false);
    }

    IEnumerator SpawnCustom()
    {
        if (customObjectPool.CanSpawn("Custom"))
        {
            CustomObject customObject = customObjectPool.Spawn("Custom");
            GameObject go = Instantiate((GameObject)customObject.Target, TextContain);
            Debug.Log(customObject.Target);
            yield return new WaitForSeconds(2);
            customObjectPool.Unspawn(customObject.Target);
        }
        else
        {
            RegisterCustom();
        }
    }
}
