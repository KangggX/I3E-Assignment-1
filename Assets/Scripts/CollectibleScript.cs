using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public bool isDetected;
    public float fresnelPower;

    public void Update()
    {
        detectionChecker();
    }

    private void detectionChecker()
    {
        if (isDetected)
        {
            gameObject.GetComponent<MeshRenderer>().materials[1].SetFloat("_fresnelPower", 3);
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().materials[1].SetFloat("_fresnelPower", 100);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger enter");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger exit");
    }


}
