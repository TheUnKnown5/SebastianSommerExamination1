using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltSize : MonoBehaviour
{
    void Update()
    {
        transform.localScale = transform.localScale + new Vector3(Random.Range(-0.002f, 0.002f), Random.Range(-0.002f, 0.002f), 0);
    }
}
