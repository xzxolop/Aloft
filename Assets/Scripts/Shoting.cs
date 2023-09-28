using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Shoting : MonoBehaviour
{   
    public Transform firePoint; 
    public GameObject bulletprefab;
    public AudioSource moveSound;
    private GameObject ui;
    public Player player;
    public EnergyTracker et;
    public Slider slider;
        private bool corutineWork = false;
        private Weapons weapons;
        private int WeapId;

    public void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !this.IsPointerOverUIObject() && !corutineWork)
        {
            StartCoroutine(Shoot());
            if (slider.value > 0)
            {
                et.UpdateTracker(false);
                
            }

        WeapId = wheelController.weaponID;
        }



     IEnumerator Shoot() 
    {
        corutineWork = true;
        Instantiate(bulletprefab, firePoint.position, Quaternion.identity);
            moveSound.Play();
            yield return new WaitForSeconds(1);
        corutineWork = false;


    }
    

    void Start()
    {
        player = GetComponent<Player>();        
        weapons = GetComponent<Weapons>();
    }
    }

    private bool IsPointerOverUIObject()
    {
        // get current pointer position and raycast it
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

        // check if the target is in the UI
        foreach (RaycastResult r in results)
        {
            bool isUIClick = r.gameObject.transform.IsChildOf(this.ui.transform);
            if (isUIClick)
            {
                return true;
            }
        }
        return false;
    }




}
