//=====================================================
// - FileName:      DataTableExtension.cs
// - Created:       #AuthorName#
// - CreateTime:      #CreateTime#
// - Email:         #AuthorEmail#
// - Description:   
// -  (C) Copyright 2020, SlagObjectPool, Inc.
// -  All Rights Reserved.
//======================================================
using GameFramework;
using System;
using UnityGameFramework.Runtime;

namespace ZZ
{
	public static class DataTableExtension {

        private const string DataRowClassPrefixName = "ZZ.DR";
        internal static readonly char[] DataSplitSeparators = new char[] { '\t' };
        internal static readonly char[] DataTrimSeparators = new char[] { '\"' };

        public static void LoadDataTable(this DataTableComponent dataTableComponent, string dataTableName, LoadType loadType, object userData = null)
        {
            if (string.IsNullOrEmpty(dataTableName))
            {
                Log.Warning("Data table name is invalid.");
                return;
            }

            string[] splitNames = dataTableName.Split('_');
            if (splitNames.Length > 2)
            {
                Log.Warning("Data table name is invalid.");
                return;
            }

            string dataRowClassName = DataRowClassPrefixName + splitNames[0];

            Type dataRowType = Type.GetType(dataRowClassName);
            if (dataRowType == null)
            {
                Log.Warning("Can not get data row type with class name '{0}'.", dataRowClassName);
                return;
            }

            string dataTableNameInType = splitNames.Length > 1 ? splitNames[1] : null;
            dataTableComponent.LoadDataTable(dataRowType, dataTableName, dataTableNameInType, AssetUtility.GetDataTableAsset(dataTableName, loadType), loadType, Constant.AssetPriority.DataTableAsset, userData);
        }
    }
}
