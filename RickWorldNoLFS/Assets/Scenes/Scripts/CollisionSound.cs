using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{

    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
            audioData.Play(0);
    }
}