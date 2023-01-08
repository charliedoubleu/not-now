using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCont : MonoBehaviour
{
    public float lifeTime;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Destroy(gameObject, lifeTime);
    }
}
