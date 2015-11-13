using UnityEngine;
using System.Collections;

public class AlienWalk : MonoBehaviour
{
    private bool dirRight;
    private float speed;

    private float right;
    private float left;

    void Start()
    {
        dirRight = true;
        speed = Random.Range(2,5);

        right = 190;
        left = -10;
    }

    void Update()
    {
        if (dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else{
            transform.Translate(-Vector2.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (transform.position.x >= right)
        {
            dirRight = false;
        }
        if (transform.position.x <= left)
        {
            dirRight = true;
        }
    }
}