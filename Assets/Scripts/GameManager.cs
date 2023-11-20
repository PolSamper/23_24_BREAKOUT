using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int vidas = 3;
    public Vidas Corazones;

    public void LosseHealth()
    {
        

       
        if (Corazones.vidas <= 0)
        {

            SceneManager.LoadScene("GameOver");


        }
    }
}
