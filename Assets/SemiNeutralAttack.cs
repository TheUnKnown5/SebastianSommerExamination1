using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemiNeutralAttack : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            transform.localScale += new Vector3(0.5f, 0.5f, 0);
        }
    }
}
