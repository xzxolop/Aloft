using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponWheelButtonController : MonoBehaviour
{


    //Variables
    public int Id;
    private Animator anim;
    public string itemName;
    public TextMeshProUGUI itemText;
    public Image selecteditem;
    private bool selected = false;
    public Sprite icon;
    
    
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        if (selected && wheelController.IsTabble) 
        {
            selecteditem.sprite = icon;
            itemText.text = itemName;
        }
    }


    public void Selected() 
    {
        if (!wheelController.IsTabble) return;
        
        selected = true;
        wheelController.weaponID = Id;
        

    }



    public void Deselected()
    {
        if (!wheelController.IsTabble) return;
        selected = false;
        wheelController.weaponID = 0;

    }


    public void HoverEnter() 
    {

        anim.SetBool("Hover", true);
        itemText.text = itemName;

    }


    public void HoverExit()
    {

        anim.SetBool("Hover", false);
        itemText.text = "";

    }


}
