using UnityEngine;
using System.Collections;

public class PlaySingleSound : MonoBehaviour
{
    public AudioSource source;

    public void PlaySound(AudioClip myClip)
    {
        source = GetComponent<AudioSource>();
        source.clip = myClip;
        source.PlayOneShot(myClip);
    }
}
