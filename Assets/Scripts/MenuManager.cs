using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public AudioSource clickSound; // assign AudioSource di Inspector

    // Tombol Play
    public void PlayGame()
    {
        if (clickSound != null)
            clickSound.Play();

        // Delay sebentar supaya suara terdengar sebelum pindah scene
        Invoke("LoadGameScene", 0.2f);
    }

    void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Tombol Exit
    public void ExitGame()
    {
        if (clickSound != null)
            clickSound.Play();

        // Delay sedikit supaya suara terdengar sebelum keluar
        Invoke("QuitApp", 0.2f);
    }

    void QuitApp()
    {
        Application.Quit();
        // Di Editor Unity, hanya log untuk testing
#if UNITY_EDITOR
        Debug.Log("Game keluar (Application.Quit() dipanggil)");
#endif
    }
}
