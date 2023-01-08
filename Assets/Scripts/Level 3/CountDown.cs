using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    private Text countDown;
    public float n;
    private float _clock;

    

    private void Start()
    {
        countDown = gameObject.GetComponent<Text>();
        countDown.text = n + "";
        _clock = n;
    }

    private void Update()
    {
        _clock -= Time.deltaTime;
        if (_clock < 1)
        {
            SceneManager.LoadScene(7);
            
        }

        countDown.text = Mathf.Floor(_clock) + "";
    }

}
