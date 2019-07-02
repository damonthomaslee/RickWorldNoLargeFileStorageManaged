using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float speed;
    public Transform control;
    public Transform target;

    void Update()
    {

        transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);

        if (control.position.y <= 0 )
        {
            transform.LookAt(target);
        }
        else transform.LookAt(Vector3.zero);
    }
}
