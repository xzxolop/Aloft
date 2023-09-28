using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{


    public GameObject CapsMenu;


    public void OpenCapsMenu() 
    {

        CapsMenu.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            CapsMenu.SetActive(false);
    }

    public void CloseCapsMenu() 
    {

        CapsMenu.SetActive(false);

    }


}
