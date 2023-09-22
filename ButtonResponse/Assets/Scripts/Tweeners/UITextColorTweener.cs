using TMPro;
using DG.Tweening;
using UnityEngine;

public class UITextColorTweener : MonoTweener
{

    [SerializeField] TextMeshProUGUI targetText;
    [SerializeField] Color targetColor;

    protected override Tweener LocalPlay()
    {
        return targetText.DOColor(targetColor, duration).SetEase(easing);
    }
}
