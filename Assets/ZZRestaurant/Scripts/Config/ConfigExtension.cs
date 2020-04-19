//=====================================================
// - FileName:      ConfigExtension.cs
// - Created:       BeanG
// - CreateTime:      2020/04/19 17:41:11
// - Email:         gongjied@hotmail.com
// - Description:   
// -  (C) Copyright 2020, SlagObjectPool, Inc.
// -  All Rights Reserved.
//======================================================
using GameFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ZZ
{
    public static class ConfigExtension
    {
        public static void LoadConfig(this ConfigComponent configComponent, string configName, LoadType loadType, object userData = null)
        {
            if (string.IsNullOrEmpty(configName))
            {
                Log.Warning("Config name is invalid.");
                return;
            }

            configComponent.LoadConfig(configName, AssetUtility.GetConfigAsset(configName, loadType), loadType, Constant.AssetPriority.ConfigAsset, userData);
        }
    }
}
