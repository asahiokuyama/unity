using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName ="Item",menuName="CreateItem")]
public class Item : ScriptableObject
{
    //public enum KindOfItem
    //{
    //    Wepon,
    //    UseItem
    //}

    //[SerializeField]
    //private KindOfItem kindOfItem;

    [SerializeField]
    private Sprite icon;

    [SerializeField]
    private string itemName;



    //public KindOfItem GetKindOfItem()
    //{
    //    return kindOfItem;
    //}

    public Sprite GetIcon()
    {
        return icon;
    }

    public string GetItemName()
    {
        return itemName;
    }

    //public string GetInformation()
    //{
    //    return information;
    //}

}
