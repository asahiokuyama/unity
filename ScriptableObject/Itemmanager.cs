using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemmanager : MonoBehaviour
{
    [SerializeField]
    private ItemDataBase itemDataBase;

    private Dictionary<Item, int> numberofitem = new Dictionary<Item, int>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < itemDataBase.GetItemLists().Count; i++)
        {
            numberofitem.Add(itemDataBase.GetItemLists()[i], i);
            //Debug.Log(itemDataBase.GetItemLists()[i].GetItemName() + ":" + itemDataBase.GetItemLists()[i].GetInformation());
            Debug.Log(itemDataBase.GetItemLists()[i].GetItemName() );
        }
        Debug.Log(GetItem("gun").GetItemName());
        Debug.Log(numberofitem[GetItem("greencube")]);
       

    }

    public Item GetItem(string serchName)
    {
        return itemDataBase.GetItemLists().Find(itemName => itemName.GetItemName() == serchName);
    }


}


