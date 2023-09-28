using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName ="Scriptable object/Item")]
public class Item : ScriptableObject
{

    [Header ("Only gameplay")]
    public TileBase tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);

    [Header("Only UI")]
    public bool stackable = true;

    public bool IsBuilding = false;


    [Header("Both")]
    public Sprite image;

    public GameObject prefab;

    public enum ItemType 
    {
        cristal,
        horn,
        kapsule

    }

    public enum ActionType 
    {
        pistol,
        mine
    }

}
