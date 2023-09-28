using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    public float AttackRange;
    public float AttackRate = 2f;
    public float NextAttackTime = 0;

    private Enemy EnemyS;
    public LayerMask enemyLayers;
    public Transform AttackPoint;
    public int AttackValue = 40;
    public Animator animator;
    public Transform player;
    //public Slider HealthBar;
    int PlayerHealth = 100;



    private void Start()
    {   
        EnemyS = GetComponent<Enemy>();
    }

    void Update()
    {
        if (Time.time >= NextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
                NextAttackTime = Time.time + 1f / AttackRate;
            }
        }
    }
    void Attack()
    {
        animator.SetTrigger("CloseCombat");

    }

    //public void GiveDamage(int Damage) 
    //{
    //    PlayerHealth-=Damage;
    //}


    void OnAttack() 
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(player.position, AttackRange, enemyLayers);
        if (hitEnemies.Length > 0)
        {
            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(AttackValue);
            }
        }

    }

    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;

        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}

