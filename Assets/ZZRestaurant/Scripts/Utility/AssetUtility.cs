//=====================================================
// - FileName:      AssetUtility.cs
// - Created:       #AuthorName#
// - CreateTime:      #CreateTime#
// - Email:         #AuthorEmail#
// - Description:   
// -  (C) Copyright 2020, SlagObjectPool, Inc.
// -  All Rights Reserved.
//======================================================
using GameFramework;
using UnityEngine;

namespace ZZ
{
	public static class AssetUtility {

        public static string GetConfigAsset(string assetName, LoadType loadType)
        {
            return Utility.Text.Format("Assets/ZZRestaurant/Configs/{0}.{1}", assetName, loadType == LoadType.Text ? "txt" : "bytes");
        }

        public static string GetUIFormAsset(string assetName)
        {
            return Utility.Text.Format("Assets/ZZRestaurant/UI/UIForms/{0}.prefab", assetName);
        }

        public static string GetDataTableAsset(string assetName, LoadType loadType)
        {
            return Utility.Text.Format("Assets/ZZRestaurant/DataTables/{0}.{1}", assetName, loadType == LoadType.Text ? "txt" : "bytes");
        }

        public static string GetDictionaryAsset(string assetName, LoadType loadType)
        {
            return Utility.Text.Format("Assets/ZZRestaurant/Localization/{0}/Dictionaries/{1}.{2}", GameEntry.Localization.Language.ToString(), assetName, loadType == LoadType.Text ? "xml" : "bytes");
        }

        public static string GetFontAsset(string assetName)
        {
            return Utility.Text.Format("Assets/ZZRestaurant/Fonts/{0}.ttf", assetName);
        }

        public static string GetSceneAsset(string assetName)
        {
            return Utility.Text.Format("Assets/ZZRestaurant/Scenes/{0}.unity", assetName);
        }

        public static string GetMusicAsset(string assetName)
        {
            return Utility.Text.Format("Assets/ZZRestaurant/Music/{0}.mp3", assetName);
        }
    }
}
