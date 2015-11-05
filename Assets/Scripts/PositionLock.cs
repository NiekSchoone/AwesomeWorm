using UnityEngine;
using System.Collections;

public class PositionLock : MonoBehaviour
{
    private float posLock;

	void Start ()
    {
        posLock = this.transform.position.y;
	}
	
	void LateUpdate ()
    {
        Vector3 tmp = transform.position;
        tmp.y = posLock;
        transform.position = tmp;
    }
}
