using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
    void Update()
    {
        GameObject moveTowardsThis = GameObject.FindWithTag("Player");
        transform.position = Vector3.MoveTowards(transform.position, moveTowardsThis.transform.position, 0.005f);
    }
}
