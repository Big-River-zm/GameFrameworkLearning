//=====================================================
// - FileName:      CopyRight.cs
// - Created:       BeanG
// - CreateTime:      2020/04/18 15:04:54
// - Email:         gongjied@hotmail.com
// - Description:   
// -  (C) Copyright 2020, SlagObjectPool, Inc.
// -  All Rights Reserved.
//======================================================

using GameFramework.Localization;
using System;
using UnityGameFramework.Runtime;
using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

namespace ZZ
{
    public class ProcedureLaunch : ProcedureBase
    {
        public override bool UseNativeDialog
        {
            get{ return true; }
        }

        protected override void OnEnter(ProcedureOwner procedureOwner)
        {
            base.OnEnter(procedureOwner);

            // ������Ϣ�������汾ʱ����һЩ������ Json �ĸ�ʽд�� Assets/GameMain/Configs/BuildInfo.txt������Ϸ�߼���ȡ��
            //GameEntry.BuiltinData.InitBuildInfo();

            // �������ã����õ�ǰʹ�õ����ԣ���������ã���Ĭ��ʹ�ò���ϵͳ���ԡ�
            InitLanguageSettings();

            // �������ã�����ʹ�õ����ԣ�֪ͨ�ײ���ض�Ӧ����Դ���塣
            //InitCurrentVariant();

            // �������ã����ݼ�⵽��Ӳ����Ϣ Assets/Main/Configs/DeviceModelConfig ���û��������ݣ����ü���ʹ�õĻ���ѡ�
            //InitQualitySettings();

            // �������ã������û��������ݣ����ü���ʹ�õ�����ѡ�
            //InitSoundSettings();

            // Ĭ���ֵ䣺����Ĭ���ֵ��ļ� Assets/GameMain/Configs/DefaultDictionary.xml��
            // ���ֵ��ļ���¼����Դ����ǰʹ�õĸ������Ե��ַ��������� App һ�𷢲����ʲ��ɸ��¡�
            //GameEntry.BuiltinData.InitDefaultDictionary();
        }

        protected override void OnUpdate(ProcedureOwner procedureOwner, float elapseSeconds, float realElapseSeconds)
        {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

            ChangeState<ProcedurePreload>(procedureOwner);
        }

        private void InitLanguageSettings()
        {
            if (GameEntry.Base.EditorResourceMode && GameEntry.Base.EditorLanguage != Language.Unspecified)
            {
                // �༭����Դģʽֱ��ʹ�� Inspector �����õ�����
                return;
            }

            Language language = GameEntry.Localization.Language;
            string languageString = GameEntry.Setting.GetString(Constant.Setting.Language);
            if (!string.IsNullOrEmpty(languageString))
            {
                try
                {
                    language = (Language)Enum.Parse(typeof(Language), languageString);
                }
                catch
                {
                }
            }

            if (language != Language.English
                && language != Language.ChineseSimplified
                && language != Language.ChineseTraditional
                && language != Language.Korean)
            {
                // �����ݲ�֧�ֵ����ԣ���ʹ��Ӣ��
                language = Language.English;

                GameEntry.Setting.SetString(Constant.Setting.Language, language.ToString());
                GameEntry.Setting.Save();
            }

            GameEntry.Localization.Language = language;

            Log.Info("Init language settings complete, current language is '{0}'.", language.ToString());
        }
    }
}
