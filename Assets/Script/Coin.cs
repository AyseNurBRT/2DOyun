using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(10); // Skor ekle
            Destroy(gameObject); // Paray� yok et
        }
    }
}

