using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonResponse : MonoBehaviour
{
    [SerializeField] Color pressedColor;
    [SerializeField] Image buttonImage;
    [SerializeField] Image pulseImage;
    [SerializeField] float colorTweenDuration;

    public void OnPressed()
    {
        // Lets toggle the color of the button
       buttonImage.DOColor(pressedColor, colorTweenDuration).OnComplete(PulseRing);
    }

    void PulseRing()
    {
        // increase the scale
        pulseImage.transform.DOScale(1.5f, 0.33f).
                                OnComplete(() => { pulseImage.transform.localScale = Vector3.one * 0.75f; });
        // fade out the aplha
        pulseImage.DOColor(Color.clear, 1f).OnComplete(() => { pulseImage.color = Color.white; });

        // when finished,
        // reset alpha and scale

    }
}
