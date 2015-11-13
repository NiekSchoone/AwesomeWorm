using UnityEngine;
using System.Collections;

public class AlienKill : MonoBehaviour
{
    public ParticleSystem bloodSplatter;

    public GameObject soundEffect;
    public AudioClip clip;
    
    public void Kill()
    {
        GameObject newBloodSplatter = Instantiate(bloodSplatter, this.transform.position, Quaternion.identity) as GameObject;
        GameObject newSoundObject = Instantiate(soundEffect, this.transform.position, Quaternion.identity) as GameObject;
        newSoundObject.GetComponent<PlaySingleSound>().PlaySound(clip);
        Destroy(this.gameObject);
    }
}
