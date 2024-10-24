using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class OvejaAnimation : MonoBehaviour
{
    public float timeToJump;
    public float jumpStrenght;

    void Start()
    {
        //transform.DOMove(transform.position + (Vector3.up * jumpStrenght), timeToJump).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InCubic);

        //Sequence mySequence = DOTween.Sequence();
        //mySequence.Append(transform.DOLocalMove(Vector3.up * jumpStrenght / 2, timeToJump));
        //mySequence.Append(transform.DOLocalMove(Vector3.up * -0.2f, timeToJump / 2));
        transform.DOLocalMove(Vector3.up * jumpStrenght, timeToJump).SetLoops(-1, LoopType.Yoyo);

        
        //mySequence.Append(transform.DOLocalJump(Vector3.zero, jumpStrenght, 1, timeToJump));
        //mySequence.SetLoops(-1);
    }
}
