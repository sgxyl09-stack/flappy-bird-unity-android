using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    public Sprite[] birdFrames;       // assign bird1..bird5 di Inspector
    public float animationSpeed = 0.1f;

    private SpriteRenderer spriteRenderer;
    private int currentFrame = 0;
    private float timer = 0f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Animasi berulang
        timer += Time.deltaTime;
        if (timer >= animationSpeed)
        {
            timer = 0f;
            currentFrame++;
            if (currentFrame >= birdFrames.Length)
                currentFrame = 0;

            spriteRenderer.sprite = birdFrames[currentFrame];
        }
    }
}
