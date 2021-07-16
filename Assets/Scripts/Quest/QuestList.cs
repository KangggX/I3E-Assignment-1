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
        foreach(string i in questList)
        {
            textPrefab.text = i;
            spawnText();
        }
    }

    private void spawnText()
    {
        Instantiate(textPrefab, questHolder);
    }
}
