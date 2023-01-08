using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StressMeter2 : MonoBehaviour
{
    public Text stressText;
    public Image stressBar;

    float maxStress = 100;
    float stress, minStress = 1;
    float lerpSpeed;

    public Transform lightBounds;

    public Transform[] spawnPoints;
    public GameObject deathSigh;
    public GameObject deathFade;
   // public AudioSource audioSource;
    public Transform spotLight;
    public GameObject sighSound;

    private SpriteRenderer _renderer;

    private void Start()
    {
        stress = 1;
        _renderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        stressText.text = "Stress Level: " + Mathf.Floor(stress) + "%";


        if (transform.position.y <= lightBounds.position.y && !deathSigh.activeInHierarchy && !deathFade.activeInHierarchy)
        {
            AddStress(0.2f);
        }
        else if (transform.position.y >= lightBounds.position.y)
        {
            SubStress(0.1f);
        }

        if (stress <= minStress)
        {
            stress = minStress;
        }

        if (stress >= maxStress)
        {
            DeathReset();
            //character dies


        }

        lerpSpeed = 3f * Time.deltaTime;

        StressBarFiller();
        ColorChanger();


    }

    void PlaySoundInterval(float fromSeconds)
    {
      //  audioSource.time = fromSeconds;
       // audioSource.Play();
        // audioSource.SetScheduledEndTime(AudioSettings.dspTime + (toSeconds - fromSeconds));
    }

    void DeathReset()
    {
        stress = 1f;
       // audioSource.Stop();
        Instantiate(sighSound, transform.position, Quaternion.identity);
        StartCoroutine(DeathTransition());
    }

    IEnumerator DeathTransition()
    {

        deathSigh.SetActive(true);//death animation: sigh
        deathFade.SetActive(true); //canvas panel fade out
        yield return new WaitForSeconds(3f);

        transform.position = spawnPoints[0].transform.position; //reset character
        transform.localEulerAngles = new Vector3(0,0,0);
        _renderer.flipY = false;
        _renderer.flipX = false;

        spotLight.position = new Vector3(spawnPoints[0].transform.position.x, 0, -3f);
        PlaySoundInterval(0); //reset song
    }

    void StressBarFiller()
    {
        stressBar.fillAmount = Mathf.Lerp(stressBar.fillAmount, stress / maxStress, lerpSpeed);
    }

    void ColorChanger()
    {
        Color stressColor = Color.Lerp(new Color32(173, 116, 43, 255), new Color32(58, 40, 17, 255), (stress / maxStress));
        stressBar.color = stressColor;
    }


    public void AddStress(float stressPoints)
    {

        stress += stressPoints;

    }

    public void SubStress(float reliefPoints)
    {
        stress -= reliefPoints;

    }
}
