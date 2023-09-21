using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorTweener : MonoTweener
{
    Color originalColor;
    [SerializeField] Image targetImage;
    [SerializeField] Color targetColor;

    protected override Tweener LocalPlay()
    {
        originalColor = targetImage.color;

        return targetImage.DOColor(targetColor, duration);
    }

    public void ResetColor()
    {
        targetImage.color = originalColor;
    }
}
