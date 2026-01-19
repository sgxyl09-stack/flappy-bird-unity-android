using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private bool isAlive = true;

    private Animator anim; // Animator component

    // 🔊 Audio
    public AudioSource flapSound;     // suara tap/flap
    public AudioSource hitSound;      // suara tabrakan

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!isAlive) return;

        // Tap layar / klik mouse
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;

            // Trigger animasi flap
            if (anim != null)
                anim.SetTrigger("Flap");

            // Mainkan suara flap
            if (flapSound != null)
                flapSound.Play();
        }

        // Rotasi burung sesuai velocity
        float angle = Mathf.Clamp(rb.velocity.y * 5f, -90f, 45f);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isAlive) return;

        // Game Over saat tabrakan
        isAlive = false;

        // Animasi mati
        if (anim != null)
            anim.SetBool("isDead", true);

        // Suara tabrakan
        if (hitSound != null)
            hitSound.Play();

        // Hentikan physics supaya burung tidak tenggelam
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Static;

        GameManager.instance.GameOver();
    }
}
