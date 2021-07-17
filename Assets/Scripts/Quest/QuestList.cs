using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestList : MonoBehaviour
{
    public Transform questHolder;
    public List<bool> currSector = new List<bool> { true, false, false };
    public List<TextMeshProUGUI> prefabList;

    /// <summary>
    /// To check if the current text button should be enabled or not
    /// </summary>
    public void sectorChecker()
    {
        for (int i = 0; i < 3; ++i)
        {
            if (currSector[i])
            {
                prefabList[i].color = Color.white;
                prefabList[i].GetComponent<QuestLink>().isEnabled = true;
                continue;
            }
            else
            {
                prefabList[i].color = Color.black;
            }
        }
    }
}
