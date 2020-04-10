using GameFramework.ObjectPool;
using System;
using UnityEngine;

namespace Tutorial
{
    /// <summary>
    /// 游戏入口。
    /// </summary>
    public partial class GameEntry : MonoBehaviour
    {
        private IObjectPool<Custom> customPool;
        private void Start()
        {
            // 初始化内置组件
            InitBuiltinComponents();

            // 初始化自定义组件
            InitCustomComponents();

            // 初始化自定义调试器
            InitCustomDebuggers();

            customPool = ObjectPool.CreateMultiSpawnObjectPool<Custom>("Customs");
            CreateCustom();
        }

        private void Update()
        {
            
        }

        private void CreateCustom()
        {
            customPool.Register(new Custom(), false);
        }
    }
}