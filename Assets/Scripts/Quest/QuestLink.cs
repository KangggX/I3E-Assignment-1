using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class QuestLink : MonoBehaviour, IPointerClickHandler
{
    public bool isEnabled;
    public GameObject screen;

    /// <summary>
    /// If button is active and screen is not active, activate the screen when button is clicked
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerClick(PointerEventData eventData)
    {
        if (isEnabled && !screen.activeInHierarchy)
        {
            screen.SetActive(true);
        }
    }
}
