using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    [Header("UI")]
    public Image image;
    public Text countText;

    [HideInInspector] public Item item;
    [HideInInspector] public int count = 1;
    [HideInInspector] public Transform parentAfterDrag;


    public void InitialiseItem(Item newItem) 
    {
        item = newItem;
        image.sprite = newItem.image;
        RefreshCount();
    }

    public void RefreshCount() 
    {
        countText.text = count.ToString();
        bool textActive = count > 1;
        countText.gameObject.SetActive(textActive);
    }

    public void BuildObject() 
    {

        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) /*- transform.position*/;
        Instantiate(item.prefab, mousePosition, Quaternion.identity);
        this.gameObject.SetActive(false);

    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (item.IsBuilding) 
        {
            Debug.Log("build!");
            BuildObject();
            return;
        }
        
         image.raycastTarget = true;
         transform.SetParent(parentAfterDrag);
        
    }


}
