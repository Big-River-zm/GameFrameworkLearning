//=====================================================
// - FileName:      LocalizationExtension.cs
// - Created:       BeanG
// - CreateTime:      2020/04/19 17:46:11
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
    public static class LocalizationExtension
    {
        public static void LoadDictionary(this LocalizationComponent localizationComponent, string dictionaryName, LoadType loadType, object userData = null)
        {
            if (string.IsNullOrEmpty(dictionaryName))
            {
                Log.Warning("Dictionary name is invalid.");
                return;
            }

            localizationComponent.LoadDictionary(dictionaryName, AssetUtility.GetDictionaryAsset(dictionaryName, loadType), loadType, Constant.AssetPriority.DictionaryAsset, userData);
        }
    }
}
