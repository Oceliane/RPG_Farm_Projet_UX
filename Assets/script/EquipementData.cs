using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Equipment")]
public class EquipementData : ItemData
{
    public enum ToolType
    {
        Hoe, WateringCan, Axe, Pickaxe, Shovel,
    }
    public ToolType toolType;

}

