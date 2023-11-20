using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala : MonoBehaviour
{
    public float velocidad;
    public bool Player;
 

    void Update()
    {
        float vertical = 0;
        float horizontal = 0;

        if (Player)
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
        }

    transform.position = transform.position + new Vector3(horizontal, vertical, 0) * velocidad * Time.deltaTime;
    }
    

}
