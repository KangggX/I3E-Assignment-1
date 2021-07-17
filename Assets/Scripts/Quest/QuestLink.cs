using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class QuestLink : MonoBehaviour, IPointerClickHandler
{
    public bool isEnabled;
    public GameObject screenToEnable;
    public GameObject screenToDisable1;
    public GameObject screenToDisable2;

    /// <summary>
    /// If button is active and screen is not active, activate the screen when button is clicked
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerClick(PointerEventData eventData)
    {
        if (isEnabled && !screenToEnable.activeInHierarchy)
        {
            //gameObject.GetComponent<TextMeshProUGUI>().color = Color.HSVToRGB(0, 0, 80);
            screenToEnable.SetActive(true);
            screenToDisable1.SetActive(false);
            screenToDisable2.SetActive(false);
        }
    }
}
