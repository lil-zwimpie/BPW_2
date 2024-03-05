using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class soundtouch : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "arrow_Shoot(Clone)")
        {
            if(!audioSource.isPlaying)
            {
                audioSource.Play();
            }
            //score omhoog doen
            scoreManager.ScoreCount += 10;
        }
    }
}