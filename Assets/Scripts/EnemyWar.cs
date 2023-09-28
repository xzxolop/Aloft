using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWar : MonoBehaviour
{

    //public GameObject obj;
    public List<GameObject> enemies;

    private void OnTriggerEnter2D(Collider2D other)
    {
            if(other.CompareTag("Player"))
            {


            foreach (var enemy in enemies)
            {
                enemy.SetActive(true);
            }

            }
    }







}
