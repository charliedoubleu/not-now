using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject clickSound;
    public GameObject transitionAnim;
    public GameObject title;


    public void PlayGame()
    {
        GetComponent<Button>().enabled = false;
        Instantiate(clickSound, transform.position, Quaternion.identity);
        
        StartCoroutine(PlayTransition());
        
        
    }

    IEnumerator PlayTransition()
    {
        transitionAnim.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        gameObject.SetActive(false);
        title.SetActive(false);
    }
}
