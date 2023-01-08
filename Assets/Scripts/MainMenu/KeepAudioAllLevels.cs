using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAudioAllLevels : MonoBehaviour
{
    private AudioSource song;
    static bool AudioBegin = false;
    private void Awake()
    {
        song = GetComponent<AudioSource>();
        if (!AudioBegin)
        {
            song.Play();
            DontDestroyOnLoad(gameObject);
            AudioBegin = true;
        }
    }
}
