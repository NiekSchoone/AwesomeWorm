using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.tag == "Alien")
        {
            target.GetComponent<AlienKill>().Kill();
        }
    }
}
