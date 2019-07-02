using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfter3Sec : MonoBehaviour
{


    void Update()
    {
        Destroy(gameObject, 2);
    }
}
