using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    public float maxY;
    public float minY;
    public float maxX;
    public float minX;
    void Update()
    {
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY);
        }
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY);
        }

        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y);
        }
        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y);
        }
    }
}
