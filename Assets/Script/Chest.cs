using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Oyun Kazan�ld�!");
            SceneManager.LoadScene("GameWin");
        }
    }
}
