using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxManager : MonoBehaviour
{
    public GameObject lightSound;

    public void playSound()
    {
        Instantiate(lightSound, transform.position, Quaternion.identity);
    }
}
