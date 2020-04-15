//=====================================================
// - FileName:      CopyRight.cs
// - Created:       #AuthorName#
// - CreateTime:      #CreateTime#
// - Email:         #AuthorEmail#
// - Description:   
// -  (C) Copyright 2020, SlagObjectPool, Inc.
// -  All Rights Reserved.
//======================================================
using UnityEngine;
using System.Collections;
using System.IO;

public class Copyright : UnityEditor.AssetModificationProcessor
{
    private const string AuthorName = "BeanG";
    private const string AuthorEmail = "gongjied@hotmail.com";

    private const string DateFormat = "yyyy/MM/dd HH:mm:ss";
    private static void OnWillCreateAsset(string path)
    {
        path = path.Replace(".meta", "");
        if (path.EndsWith(".cs"))
        {
            string allText = File.ReadAllText(path);
            allText = allText.Replace("#AuthorName#", AuthorName);
            allText = allText.Replace("#AuthorEmail#", AuthorEmail);
            allText = allText.Replace("#CreateTime#", System.DateTime.Now.ToString(DateFormat));
            File.WriteAllText(path, allText);
            UnityEditor.AssetDatabase.Refresh();
        }
    }
}
