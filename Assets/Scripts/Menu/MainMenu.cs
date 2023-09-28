using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


public void PlayGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
}


    public void GoMenu() 
    {

        SceneManager.LoadScene(0);
    }

void Update()
{
    //if(Input.GetKeyDown(KeyCode.Escape))
    //{
    //Application.Quit();
    //}
}

    public void ExitGame()
    {   
        Application.Quit();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex  = 2);
        //SceneManager.LoadScene(0);
    }


}
