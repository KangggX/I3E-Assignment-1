using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestList : MonoBehaviour
{
    public List<string> questList;

    private void Awake()
    {
        foreach(string i in questList)
        {
            Debug.Log(i);
        }
    }
}
