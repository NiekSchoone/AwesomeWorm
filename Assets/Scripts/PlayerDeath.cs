using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public GameObject restart;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Obstacle")
        {
            Die();
        }
    }

    void Die()
    {
        restart.SetActive(true);
        Destroy(GetComponent<PlayerControlScript>());
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
