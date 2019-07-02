using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundDeleteAfterAnother2Hits : MonoBehaviour
{

    AudioSource audioData;

    private bool played = true;
    private bool disappear = true;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    { 
        if (disappear == false)
        {
            Destroy(gameObject);
        }

        if (played == false)
        {
            audioData.Play(0);
            disappear = false;
        }
        if (played == true)
        {
            audioData.Play(0);
            played = false;
        }
    }
}
