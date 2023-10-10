using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    void Update()
    {
        transform.localScale = transform.localScale + new Vector3(Random.Range(-.002f,.002f), Random.Range(-.002f,.002f), 0);

        Debug.Log("Growing");
    }
}
