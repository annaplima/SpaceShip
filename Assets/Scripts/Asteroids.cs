using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteroids : MonoBehaviour
{
    public float horizontalSpeed = 5f;
    public float verticalSpeed = 2f; // Adiciona velocidade vertical

    public float leftEdge;
    public float topEdge;
    public int lives = 3;
    public GUISkin layout;

    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
        topEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y - 1f;
    }

    void Update()
    {
        // Move o objeto para a esquerda
        transform.position += Vector3.left * horizontalSpeed * Time.deltaTime;

        // Move o objeto para cima
        transform.position += Vector3.up * verticalSpeed * Time.deltaTime;
    }

    // Usar OnTriggerEnter com um parâmetro de tipo Collider
    void OnTriggerEnter2D(Collider2D other )
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Colidiu com o jogador, perde uma vida
            lives--;
            Destroy(gameObject);

            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void OnGUI()
    {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "VIDAS:  " + lives);
    }
}
