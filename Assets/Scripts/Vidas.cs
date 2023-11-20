using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public int vidas;
    public TextMeshProUGUI vidastexto;

    // Update is called once per frame
    void Update()
    {
       vidastexto.text = vidas.ToString();
    }
}
