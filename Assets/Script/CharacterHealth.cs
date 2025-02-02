using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour
{
    //Health
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    //EnemySpacing
    public bool enemyattack;
    public float enemytimer;


    public Animator anim;



    void Start()
    {
        currentHealth = maxHealth;
        enemytimer = 1.5f;

        anim = GetComponent<Animator>();
    }

    //Düþmanýn hasar verme aralýðý
    void EnemyAttackSpacing()
    {
        if (enemyattack == false)
        {
            enemytimer -= Time.deltaTime;
        }
        if(enemytimer< 0)
        {
            enemytimer = 0f;
        }
        if (enemytimer == 0f)
        {
            enemyattack = true;
            enemytimer = 1.5f;
        }
    }

    //Düþmaný kitlemek için
    void CharacterDamage()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemyattack = false;
        }
    }

    //Hasar Alma
    public void TakeDamage(int damage)
    {
        if (enemyattack == true)
        {
            currentHealth -= 20;
            enemyattack = false;
            anim.SetTrigger("isHurt");
        }

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
    }

    void Die()
    {
        anim.SetBool("isDead", true);

        GetComponent<CharacterMove>().enabled = false;
        Destroy(gameObject, 2f);
        SceneManager.LoadScene("GameOver"); // Game Over sahnesini yükler
    }




    // Update is called once per frame
    void Update()
    {
        EnemyAttackSpacing();
        CharacterDamage();

        if (Input.GetKeyDown(KeyCode.Z))
        {
            TakeDamage(20);
        }
    }
}
