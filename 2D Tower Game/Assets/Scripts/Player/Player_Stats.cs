using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Stats : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    public int resistance = 1;
    private int currentHealt;
    public int attackdamage = 40;


    // Start is called before the first frame update
    void Start()
    {
        currentHealt = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealt -= (damage / resistance );

        //Player hurt animation
        animator.SetTrigger("Hurt");

        if(currentHealt <= 0)
        {
            Die();
            currentHealt = 0;
        }
    }

    void Die()
    {
        //Die animation
        animator.SetBool("IsDead", true);

        //Disable the enemy
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;



    }

}
