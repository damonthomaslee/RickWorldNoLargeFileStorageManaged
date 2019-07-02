using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript: MonoBehaviour
{
    public Transform[] target;
    public float posSpeed;
    public float rotSpeed;

    private int current;

    void Update()
    {
        //Falls Position inkorrekt, tue dies:

        Vector3 targetDir = target[current].position - transform.position;


        if (transform.position != target[current].position)
        {
            Vector3 rot = Vector3.RotateTowards(transform.forward, targetDir, rotSpeed * Time.deltaTime, 0.0f);

            transform.rotation = Quaternion.LookRotation(rot);


            if (transform.position != target[current].position)
            {
                Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, posSpeed * Time.deltaTime);

                GetComponent<Rigidbody>().MovePosition(pos);
            }
        }

        else current = (current + 1) % target.Length;
    }
}
