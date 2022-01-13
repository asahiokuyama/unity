using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    [SerializeField]
    private ItemDataBase itemDataBase;
    public Image image1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add_image()
    {
        Debug.Log("aaa");
        image1.enabled = true;
        image1.sprite = GetItem("greencube").GetIcon();
    }
    public Item GetItem(string serchName)
    {
        return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == serchName);
    }
}
