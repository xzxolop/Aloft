using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int health;
    int maxHealth = 100;

    public List<GameObject> prefs;
    private EnergyTracker energyText;
    public Animator animator;
    public GameObject Blood;
    private Player player;
    //For Movement---
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    private Vector2 movement;
    public float speed = 0.1f;
    public int damage = 10;
    private float timeBtwAttack;
    public float StartTimeBtwAttack;
    private int trm = 0;
    private bool IsTakeMove = false;
    private Vector3 direction;
    

    void Start()
    {
        // energyText = GetComponent<EnergyTracker>();
        energyText = FindObjectOfType<EnergyTracker>();
        player = FindObjectOfType<Player>();
        health = maxHealth;
        rb = this.GetComponent<Rigidbody2D>();  //-
        bc = this.GetComponent<BoxCollider2D>();

        
    }

    void Update()
    {

        //CheckPlayerposition();

    }

    //обновление позиции игрока
    void CheckPlayerposition() 
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
    }

    //Получение урона(урон по Enemy)
    public void TakeDamage(int damage)
    {
        
        health -= damage;
        if (health > 0) animator.SetTrigger("Hurt");
        Debug.Log(health);
        if (health <= 0)
        {
            energyText.GetComponent<EnergyTracker>().UpdateTracker(true);
            //EnergyTracker.energyText.UpdateTracker();
            
            
            animator.SetTrigger("Death");
            this.enabled = false;
            bc.enabled = false;            //Отключение коллайдера после смерти\
            Destroy(this.gameObject,1.0f);
            DropLoot();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
    if(collision.gameObject.CompareTag("Bullet") && this.enabled == true)
    {
      TakeDamage(50);
      //Instantiate(Blood, transform.position, Quaternion.identity);
    }
  }


//For Movement
void FixedUpdate()
   {
        direction = player.transform.position - transform.position;

        if (math.abs(direction.x) < 10 && math.abs(direction.y) < 5)
        {
            if (IsTakeMove == false)
            {
                animator.SetBool("TakeMove", true);
                IsTakeMove = true;
            }
            MoveChar(movement);
            CheckPlayerposition();
        }
        else 
        {
           
            if(IsTakeMove == true) 
            {
                IsTakeMove=false;
                animator.SetBool("TakeMove", false);
            }

        }

   }

    void MoveChar(Vector2 direction)
   {
       rb.MovePosition((Vector2)transform.position + (direction * speed *  Time.deltaTime));
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
       
   }
    //-------------------



    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && health > 0)
        {

                if (trm == 0)
                {
                    animator.SetTrigger("Attack");
                    player.health -= damage;
                    trm = 80;
                }

                else
                {
                    timeBtwAttack -= Time.deltaTime;
                    trm -= 1;
                }


        }


    }

    //Последствия удара врага(Прикрелён к аниматору конца удара)
    public void onEnemyAttack() 
    {
       // Instantiate(Blood,player.transform.position, Quaternion.identity);
        player.health -= damage;
        timeBtwAttack = StartTimeBtwAttack;
        //trm -= 1;
        player.UpdateHealthBar(damage);
    }


    private void DropLoot() 
    {

        Instantiate(prefs[0], transform.position, quaternion.identity);


    }



}