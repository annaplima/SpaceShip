using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLittle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroidPrefab;
    public Camera mainCamera; // Use a câmera como referência
    private float spawnInterval = 2.35f;

    private float posicaoy = -1.5f;
    private float posicaox = 5.0f;

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
                cameraX +posicaox, // Ajuste os valores de acordo com a área desejada
                cameraY + posicaoy, // Ajuste os valores de acordo com a área desejada
                1.0f
            );

            // Instancia o asteroide na posição calculada
            Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
