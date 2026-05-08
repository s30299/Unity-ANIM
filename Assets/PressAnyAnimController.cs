using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PressAnyAnimController : MonoBehaviour
{
    [SerializeField] RectTransform logo;
    [SerializeField] CanvasGroup buttons;
    [SerializeField] GameObject buttonAny;
    public void PressAnyButton()
    {
        Sequence nSeq = DOTween.Sequence();
        nSeq.Append(logo.DOAnchorPosY(500,1));
        nSeq.Insert(0, logo.transform.DOScale(new Vector3(1,1,1),1));
        nSeq.Insert(0.5f, buttons.DOFade(1,1f));
        nSeq.OnComplete(()=>buttonAny.SetActive(false));
    }
}
