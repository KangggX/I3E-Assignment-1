using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestList : MonoBehaviour
{
    public List<string> questList;
    public TextMeshProUGUI textPrefab;
    public Transform questHolder;

    private void Awake()
    {
        
        //ListSorter(12, 12);
    }

    public void ListSorter(int start, int end)
    {
        for(int i = start; i < end; ++i)
        {
            textPrefab.text = questList[i];
            SpawnText();
        }
    }

    private void SpawnText()
    {
        Instantiate(textPrefab, questHolder);
    }
}
