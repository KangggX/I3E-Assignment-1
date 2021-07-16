using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{
    public ScriptableObject playerData;
    public int value;
    public string objectType;

    private string[] objectTypeArray = new string[] {"batteryAmount", "cardAmount", "fuse", "finalFuse"};
    public void Collectible()
    {
        gameObject.SetActive(false);

        foreach (string i in objectTypeArray)
        {
            if (objectType == i)
            {
                
            }
        }
    }

    public void Crate()
    {

    }

    public void DetectionChecker(bool state)
    {
        if (state)
        {
            gameObject.GetComponent<MeshRenderer>().materials[1].SetFloat("_fresnelPower", 2);
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().materials[1].SetFloat("_fresnelPower", 100);
        }
    }
}
