using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntuacion : MonoBehaviour
{
    public int puntuacion;
    public TextMeshProUGUI puntuaciontexto;

    // Update is called once per frame
    void Update()
    {
        puntuaciontexto.text = puntuacion.ToString();
    }
}
