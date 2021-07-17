using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Item Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class PlayerItemData : ScriptableObject, ISerializationCallbackReceiver
{
    public int currentBatteryAmount;
    public int currentCardAmount;
    public int currentFuseAmount;
    public int currentFinalFuseAmount;

    public int initialBatteryAmount;
    public int initialCardAmount;
    public int initialFuseAmount;
    public int initialFinalFuseAmount;

    public void OnAfterDeserialize()
    {
        currentBatteryAmount = initialBatteryAmount;
        currentCardAmount = initialCardAmount;
        currentFuseAmount = initialFuseAmount;
        currentFinalFuseAmount = initialFinalFuseAmount;
    }

    public void OnBeforeSerialize()
    {

    }
}
