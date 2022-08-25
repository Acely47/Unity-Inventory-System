using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/Items/Equipment")]
public class EquipmentObject : ItemObject
{ // values for items
    public float damage;
    public float defence;
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
