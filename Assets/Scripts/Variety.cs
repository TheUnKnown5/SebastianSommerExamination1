using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Variety : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(.5f, .5f, 0);
        }
        if (other.gameObject.tag == "g")
        {

        }
    }
}
