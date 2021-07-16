using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public bool isDetected;
    public float fresnelPower;

    public void Update()
    {
        if(isDetected)
        {
            fresnelChanger(3);
        } 
        else
        {
            fresnelChanger(100);
        }
    }

    private MeshRenderer fresnelChanger(float power)
    {
        return gameObject.GetComponent<MeshRenderer>().materials[1].SetFloat("_fresnelPower", power);
    }
}
