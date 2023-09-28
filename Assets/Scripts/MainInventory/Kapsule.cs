using UnityEngine;
using UnityEngine.EventSystems;

public class Kapsule : MonoBehaviour
{

    public BoxCollider2D bxd;

    private bool isDragging;


    private void OnMouseDown()
    {
        isDragging = true;
    }


    private void OnMouseUp()
    {
        isDragging = false;
        bxd.enabled = true;
    }


    private void Update()
    {

        if (isDragging == true)
        {   
            bxd.enabled = false;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }


    }



}
