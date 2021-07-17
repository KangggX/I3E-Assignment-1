using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestGoal : MonoBehaviour
{
    public PlayerData playerData;
    public TextMeshProUGUI[] textArray;

    public string[] objectType;
    public int[] currValue;
    public int[] requiredValue;

    private void Update()
    {
        for (int i = 0; i < textArray.Length; ++i)
        {
            currValue[i] = StringConvert(objectType[i]);
            textArray[i].text = currValue[i] + "/" + requiredValue[i];

            if (currValue[i] == requiredValue[i])
            {
                textArray[i].text = "Completed!!!";
                textArray[i].color = Color.green;
            }
        }
    }

    private int StringConvert(string i)
    {
        if (i == "Battery")
        {
            return playerData.currentBatteryAmount;
        }
        else if (i == "Card")
        {
            return playerData.currentCardAmount;
        }
        else if (i == "Fuse")
        {
            return playerData.currentFuseAmount;
        }
        else
        {
            return playerData.currentAdvancedFuseAmount;
        }
    }
}
