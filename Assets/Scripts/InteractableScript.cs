using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{
    public int value;
    public string objectType;

    public void Update()
    {
        
    }

    public void Interaction()
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
