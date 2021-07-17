using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Item Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class PlayerItemData : ScriptableObject
{
    public int batteryAmount;
    public int cardAmount;
    public int fuse;
    public int finalFuse;
}
