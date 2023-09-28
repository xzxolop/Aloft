using UnityEngine;
using UnityEngine.UI;

public class wheelController : MonoBehaviour
{


    public Animator anim;
    private bool weaponWheelSelected = false;
    public Image selectedItem;
    public Sprite noImage;
    public static int weaponID;
    public static bool IsTabble = false;


    void Start()
    {
        
    }

    
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Tab)) 
        {


            weaponWheelSelected = !weaponWheelSelected;
            IsTabble = !IsTabble;

        }


        if (weaponWheelSelected && IsTabble)
        {

            anim.SetBool("openWeaponWheel", true);

        }

        else 
        {
            anim.SetBool("openWeaponWheel", false);

        }


        switch (weaponID) 
        {

            case 0:
                selectedItem.sprite = noImage;
                //Debug.Log("NoImage");
                break;
            case 1:
                //Debug.Log("Pistol");
                break;
            case 2:
                //Debug.Log("Suzzi");
                break;

            case 3:
                //Debug.Log("3");
                break;

        }



    }
}
