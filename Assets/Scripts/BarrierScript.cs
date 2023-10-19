using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    void Awake()
    {
        PolygonCollider2D c = GetComponent<PolygonCollider2D>();
        if (c == null) { c = gameObject.AddComponent<PolygonCollider2D>(); }
        Vector2[] points = c.points;
        EdgeCollider2D e = gameObject.AddComponent<EdgeCollider2D>();
        e.points = points;
        Destroy(c);
    }
}
