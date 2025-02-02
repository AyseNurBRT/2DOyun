using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinManager : MonoBehaviour
{
    // Tekrar butonu için
    public void RetryGame()
    {
        SceneManager.LoadScene("SampleScene"); // Ana oyun sahnesine döner
    }

    // Çýkýþ butonu için
    public void ExitGame()
    {
        SceneManager.LoadScene("Menu"); ; // Oyundan çýkar
        Debug.Log("Game Quit!"); // Test için
    }
}
