using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTweenExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var seq = DOTween.Sequence();
        seq.Append(transform.DOMove(new Vector3(10, 15, 10), 4));
        seq.Append(transform.DORotate(new Vector3(180, 0, 0), 4));
        seq.SetLoops(-1);
    }

    private void AfterAnimation()
    {
        Debug.Log("Animation complete");
    }
}
