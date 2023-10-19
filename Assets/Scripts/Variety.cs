using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Variety : MonoBehaviour
{
    [SerializeField] float maxVal = 1.5f;
    [SerializeField] float minVal = -1.5f;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.5f, 0.5f, 0);
            //transform.localScale = new Vector2(Mathf.Clamp(Random.Range(Vector3 ,minVal, maxVal)), 0);
            //transform.localScale = new Vector2(0, Mathf.Clamp(Random.Range(-0.002f, 0.002f), minVal, maxVal));
        }
        if (other.gameObject.tag == "Allies")
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.5f, 0.5f, 0);
        }
    }
}
