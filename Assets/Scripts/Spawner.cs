using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public Camera mainCamera; // Use a câmera como referência
    private float spawnInterval = 10.0f;

    public float posicaoy = 4.0f;
    public float posicaox = -8.0f;

    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            // Obtém as coordenadas da câmera
            float cameraX = mainCamera.transform.position.x;
            float cameraY = mainCamera.transform.position.y;

            // Calcula uma posição aleatória próxima à câmera
            Vector3 spawnPosition = new Vector3(
                cameraX- posicaox, // Ajuste os valores de acordo com a área desejada
                cameraY- posicaoy, // Ajuste os valores de acordo com a área desejada
                0f
            );

            // Instancia o asteroide na posição calculada
            Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
