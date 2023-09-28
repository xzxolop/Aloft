using UnityEngine;
using UnityEngine.UI;

public class HealthUpper : MonoBehaviour
{
    
    public Slider healthBar;
    public Slider EnergyBar;
    public Text healthText;

    public void UpHp(int hp) 
    {
        if (EnergyBar.value < hp) return;

        
        healthBar.maxValue += hp;
        healthBar.value = healthBar.maxValue;
        EnergyBar.value  -= hp;
        healthText.text = healthBar.value.ToString();

    }




}
