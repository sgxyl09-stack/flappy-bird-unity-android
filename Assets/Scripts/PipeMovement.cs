using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 2f; // kecepatan pipa

    void Update()
    {
        // Pindah ke kiri
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Hancurkan jika keluar layar (x < -10)
        if (transform.position.x < -10f)
            Destroy(gameObject);
    }
}
