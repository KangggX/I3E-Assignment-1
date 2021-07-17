using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSector : MonoBehaviour
{
    public GameObject questUI;
    public int sector;

    private void OnTriggerEnter(Collider other)
    {
        questUI.GetComponent<QuestList>().currSector[sector] = true;
    }
}
