using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltSize : MonoBehaviour
{
    [SerializeField] float maxVal = 1.5f;
    [SerializeField] float minVal = -1.5f;
    void Update()
    {
        transform.localScale = transform.localScale + new Vector3(Random.Range(-0.002f, 0.002f), Random.Range(-0.002f, 0.002f), 0);
        //transform.localScale = new Vector2(Mathf.Clamp(Random.Range(-0.002f, 0.002f), minVal, maxVal), 0);
        //transform.localScale = new Vector2(0, Mathf.Clamp(Random.Range(-0.002f, 0.002f), minVal, maxVal));
    }
}
