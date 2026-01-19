using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool scored = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (!scored && col.CompareTag("Player"))
        {
            scored = true;
            GameManager.instance.AddScore(1); // menambah skor
        }
    }
}
