using UnityEngine;

public class PickUp : MonoBehaviour
{
    private InventoryManager inventoryManager;
    public Item slotButton;

    private void Start()
    {
        inventoryManager = GameObject.FindGameObjectWithTag("inventoryManager").GetComponent<InventoryManager>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {

            bool result = inventoryManager.AddItem(slotButton);
            Destroy(gameObject);

        }
        
    }
    
}
