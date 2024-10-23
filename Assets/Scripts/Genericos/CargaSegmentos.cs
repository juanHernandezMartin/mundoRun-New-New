using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaSegmentos : MonoBehaviour
{
    public float ZdistanceBettweenSegments;
    public List<GameObject> segments;

    public void Start()
    {
        for( int currSegment = 0; currSegment < segments.Count; currSegment++ )
        {
            Vector3 offset = Vector3.forward * currSegment * ZdistanceBettweenSegments;
            Instantiate(segments[currSegment], offset, transform.rotation);
        }
    }
}
