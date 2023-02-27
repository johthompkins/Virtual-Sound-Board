using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundController : MonoBehaviour
{

    public void PlaySound()
    {
        if(!gameObject.GetComponent<AudioSource>().isPlaying)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    public void StopAllSound()
    {
        AudioSource[] allSoundEffects;

        allSoundEffects = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

        foreach(AudioSource source in allSoundEffects)
        {
            source.Stop();
        }
    }
}
