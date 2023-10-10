using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variety : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);
            transform.localScale += new Vector3(.5f, .5f, 0);
        }
    }

    void Update()
    {
        transform.localScale += new Vector3 (Random.Range(-.02f,.02f), Random.Range(-.02f,.02f), Random.Range(0,0));
        //transform.position = transform.position + new Vector3(Random.Range(-.05f,.05f), Random.Range(-.05f,.05f), Random.Range(0,0));
        // Wobble

        //Debug.Log("Growing");
    }
}
