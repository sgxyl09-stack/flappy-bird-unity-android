using UnityEngine;

public class ProfileManager : MonoBehaviour
{
    public GameObject profileWindow; // assign panel image
    public AudioSource clickSound;   // assign AudioSource untuk suara klik tombol

    // Fungsi toggle window
    public void ToggleProfileWindow()
    {
        if(clickSound != null)
            clickSound.Play();

        if(profileWindow != null)
            profileWindow.SetActive(!profileWindow.activeSelf);
    }

    // Fungsi khusus untuk menutup window (jika pakai tombol X di window)
    public void CloseProfileWindow()
    {
        if(clickSound != null)
            clickSound.Play();

        if(profileWindow != null)
            profileWindow.SetActive(false);
    }
}
