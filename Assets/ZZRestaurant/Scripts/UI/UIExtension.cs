//=====================================================
// - FileName:      UIExtension.cs
// - Created:       BeanG
// - CreateTime:      2020/04/16 22:09:03
// - Email:         gongjied@hotmail.com
// - Description:   
// -  (C) Copyright 2020, SlagObjectPool, Inc.
// -  All Rights Reserved.
//======================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace ZZ
{
	public static class UIExtension {
        public static IEnumerator FadeToAlpha(this CanvasGroup canvasGroup, float alpha, float duration)
        {
            float time = 0f;
            float originalAlpha = canvasGroup.alpha;
            while (time < duration)
            {
                time += Time.deltaTime;
                canvasGroup.alpha = Mathf.Lerp(originalAlpha, alpha, time / duration);
                yield return new WaitForEndOfFrame();
            }

            canvasGroup.alpha = alpha;
        }

        public static void CloseUIForm(this UIComponent uiComponent, UGUIForm uiForm)
        {
            uiComponent.CloseUIForm(uiForm.UIForm);
        }
    }
}
