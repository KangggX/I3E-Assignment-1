using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public GameObject questList;
    private void Awake()
    {
        questList.GetComponent<QuestList>().ListSorter(0, 2);
    }
}
