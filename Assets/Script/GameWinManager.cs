using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWinManager : MonoBehaviour
{
    // Tekrar butonu i�in
    public void RetryGame()
    {
        SceneManager.LoadScene("SampleScene"); // Ana oyun sahnesine d�ner
    }

    // ��k�� butonu i�in
    public void ExitGame()
    {
        SceneManager.LoadScene("Menu"); ; // Oyundan ��kar
        Debug.Log("Game Quit!"); // Test i�in
    }
}
