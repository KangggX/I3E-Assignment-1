using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Item Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class PlayerData : ScriptableObject, ISerializationCallbackReceiver
{
    public int currentBatteryAmount;
    public int currentCardAmount;
    public int currentFuseAmount;
    public int currentAdvancedFuseAmount;

    public int initialBatteryAmount;
    public int initialCardAmount;
    public int initialFuseAmount;
    public int initialAdvancedFuseAmount;

    public void OnAfterDeserialize()
    {
        currentBatteryAmount = initialBatteryAmount;
        currentCardAmount = initialCardAmount;
        currentFuseAmount = initialFuseAmount;
        currentAdvancedFuseAmount = initialAdvancedFuseAmount;
    }

    public void OnBeforeSerialize()
    {

    }
}
