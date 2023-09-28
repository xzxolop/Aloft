using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnergyTracker : MonoBehaviour
{
    //public int score;
    public TextMeshProUGUI scoretext;
    public GameObject energyText;
    public Player player;
    public Slider energySlider;
    public Text energyTextBar;

    public string ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoretext = energyText.GetComponent<TextMeshProUGUI>();
        energySlider.value = 0;
        energyTextBar.text = energySlider.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateTracker(bool is_picked)
    {
        if (player.bullets <= player.maxbullets)
        {
            if (is_picked)
            {
                if (energySlider.value <= 100)
                    energySlider.value += 3;
            }
            else 
            {
                energySlider.value -= 1;
                
            }
               
        }

        energyTextBar.text = energySlider.value.ToString();

        
    }
}