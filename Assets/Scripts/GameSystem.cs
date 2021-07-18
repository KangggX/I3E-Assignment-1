using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public GameObject questList;

    /// <summary>
    /// To check if the current sector has been unlocked or not
    /// </summary>
    private void Update()
    {
        questList.GetComponent<QuestList>().sectorChecker();
    }
}
