using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCollectible : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(20, 25, 40) * Time.deltaTime);
    }
}

