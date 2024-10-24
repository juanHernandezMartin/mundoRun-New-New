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
        transform.DOLocalMove(Vector3.up * jumpStrenght, timeToJump).SetLoops(-1, LoopType.Yoyo);
    }
}
