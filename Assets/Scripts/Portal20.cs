using UnityEngine;

public class Portal20 : MonoBehaviour
{
    private Player player;
    BoxCollider2D boxCollider;


    public void GoPortal()
    {
        player = FindObjectOfType<Player>();
        //boxCollider.transform.position.
        //player.transform.position = new Vector3(-61,5,player.transform.position.z);
        player.transform.position = RandomPointInBox();

    }


    private Vector3 RandomPointInBox()
    {
        return boxCollider.bounds.center + new Vector3((Random.value - 0.5f) * boxCollider.bounds.size.x, (Random.value - 0.5f) * boxCollider.bounds.size.y, (Random.value - 0.5f) * boxCollider.bounds.size.z);
    }
}
