using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Pelota : MonoBehaviour
{
    public float velocidad;
    public Vector2 direccion;
    public float minY = -5.5f;
    Rigidbody rb;
    public float maxVelocity = 15f;
    public GameManager vidas;
    int vidastotales;
    public Vidas Corazones;
    

   
    private void Start()
    {
        Spawn();
        
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3)direccion * velocidad * Time.deltaTime;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vertical")
        {
            direccion = new Vector2(-direccion.x, direccion.y);
        }
        if (collision.gameObject.tag == "Horizontal")
        {
            direccion = new Vector2(direccion.x, -direccion.y);
        }
        if (collision.gameObject.tag == "Player")
        {
            Vector3 dir =  transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir; 
            
        }
        if (collision.gameObject.tag == "Bloque")
        {
            Vector3 dir = transform.position - collision.transform.position;
            dir.Normalize();
            direccion = dir;
            collision.GetComponent<Brick>().Muerte();

            
           
            
            

        }

       

        if (collision.gameObject.tag == "Muerte")
        {
            Spawn();
            Corazones.vidas = Corazones.vidas - 1;
            
            if (Corazones.vidas <= 0)
            {
                GameOver();
                
            }

            
            
            
            
        }



    }

    void Spawn()
    {
        transform.position = new Vector3(0, 0);
        float x = Random.Range(-1f, 1f);
        if (x > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
        float y = Random.Range(-1f, 1f);
        direccion = new Vector2(x, y);
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


}
