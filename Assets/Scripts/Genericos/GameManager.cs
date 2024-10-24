using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> SegmentsParts;

    public static GameManager instance;
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void KillPlayer()
    {
        
    }
}
