using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public Puntuacion puntos;
    public int puntuaciones;
    public GameObject PowerUpRojo;
    public GameObject PowerUpVerde;
    public GameObject PowerUpAzul;

    public void Muerte()
    {
        Destroy(gameObject);
        puntos.puntuacion = puntos.puntuacion + puntuaciones;
        int num = Random.Range(0, 10);

        if(num == 0)
        {
            Instantiate(PowerUpRojo, transform.position, Quaternion.identity);
        }

        if (num == 1)
        {
            Instantiate(PowerUpVerde, transform.position, Quaternion.identity);
        }

        if (num == 2)
        {
            Instantiate(PowerUpAzul, transform.position, Quaternion.identity);
        }
    }
    




}
