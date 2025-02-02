using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator anim;
    public int maxHealth = 100;
    int currentHealth;

    public GameObject chestPrefab; // Sandık prefabı
    public GameObject coinPrefab;  // Para prefabı

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        anim.SetTrigger("Hurt");

        if (currentHealth<=0)
        {
            Die();
        }
        void Die()
        {

            anim.SetBool("IsDead", true);

            this.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 2f);

            Instantiate(chestPrefab, transform.position, Quaternion.identity);

            // Paraları rastgele dağıt
            for (int i = 0; i < 5; i++)
            {
                Vector3 randomOffset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
                Instantiate(coinPrefab, transform.position + randomOffset, Quaternion.identity);
            }

        }

    }

}
