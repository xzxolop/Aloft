using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TriggerFight : MonoBehaviour
{
    public Animator anim;
    private Behaviour enemyfire;
    private int Damage = 10;
    GameObject playerObj;
    

    private void Start()
    {
        playerObj = GameObject.FindGameObjectsWithTag("Player")[0];
        enemyfire = GetComponentInParent<Behaviour>();
        
    }


    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player") && transform.parent.gameObject.GetComponentInParent<Behaviour>().enabled == true )
    //    {
    //        anim.SetBool("Attack", true);
    //        playerObj.GetComponent<PlayerCombat>().GiveDamage(Damage);
            
           
    //    }

    //}


    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player") && transform.parent.gameObject == true)
    //    {
    //        anim.SetBool("Attack", false);
    //    }

    //}



}
