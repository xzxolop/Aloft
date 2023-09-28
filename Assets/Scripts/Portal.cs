using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    private Player player;
    public BoxCollider2D boxCollider;
    public Slider energySlider;

    public void GoPortal()
    {
        player = FindObjectOfType<Player>();
        //boxCollider.transform.position.
        //player.transform.position = new Vector3(-61,5,player.transform.position.z);
        player.transform.position = RandomPointInBox();

    }


    public void GoBackPortal() 
    {
        if (energySlider.value < 50) return;

        energySlider.value -= 50;
        Player player = FindObjectOfType<Player>();
        player.transform.position = new Vector3(-60,11,player.transform.position.z);
    }


    private Vector3 RandomPointInBox()
    {
        return boxCollider.bounds.center + new Vector3((Random.value - 0.5f) * boxCollider.bounds.size.x, (Random.value - 0.5f) * boxCollider.bounds.size.y,(Random.value - 0.5f) * boxCollider.bounds.size.z);
    }




}
