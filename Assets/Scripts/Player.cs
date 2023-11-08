using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
   

    // Update is called once per frame
    void Update()
    {
        // Verifica se a tecla para cima (W ou seta para cima) está pressionada
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            // Move a nave para cima
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        // Verifica se a tecla para baixo (S ou seta para baixo) está pressionada
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            // Move a nave para baixo
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

}
