using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab; // assign Pipe prefab
    public float spawnRate = 2f;  // tiap 2 detik spawn
    public float minY = -1f;      // posisi bawah
    public float maxY = 3f;       // posisi atas

    void Start()
    {
        // Spawn pertama 1 detik, ulang tiap spawnRate
        InvokeRepeating("SpawnPipe", 1f, spawnRate);
    }

    void SpawnPipe()
    {
        float y = Random.Range(minY, maxY);
        Vector3 spawnPos = new Vector3(10f, y, 0); // spawn di kanan layar
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
