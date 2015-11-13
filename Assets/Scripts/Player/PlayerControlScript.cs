using UnityEngine;
using System.Collections;

public class PlayerControlScript : MonoBehaviour
{
	private float moveSpeed;
	private float rotateSpeed;
    private GameObject trail;
    private Vector3 trailVectorPosition;

    private bool useGravity;
    private bool movingR = true;

    public GameObject trailPrefab;

    void Start()
    {
        moveSpeed = 10f;
        rotateSpeed = 150;
        useGravity = false;

        NewTrail();
    }

    void Update () 
	{
		// Amount to Move
		transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
		float MoveRotate = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        // Move the player
        if (transform.rotation.z > -0.70f && transform.rotation.z < 0.70f)
        {
            movingR = true;
        }else
        {
            movingR = false;
        }

        if(useGravity == true)
        {
            if (movingR == true)
            {
                if (MoveRotate < 0)
                {
                    transform.Rotate(Vector3.forward * MoveRotate);
                }
                else
                {
                    transform.Rotate(-Vector3.forward);
                }
            }else
            {
                if (MoveRotate > 0)
                {
                    transform.Rotate(Vector3.forward * MoveRotate);
                }else
                {
                    transform.Rotate(Vector3.forward);
                }
            }
        }else
        {
            transform.Rotate(Vector3.forward * MoveRotate);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "GroundSwitch")
        {
            useGravity = true;
            if (trail != null)
            {
                trail.transform.parent = null;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "GroundSwitch")
        {
            useGravity = false;
            NewTrail();
        }
    }

    void NewTrail()
    {
        trail = Instantiate(trailPrefab);
        trail.transform.parent = this.transform;
        trail.transform.localPosition = trailVectorPosition;
    }
}
