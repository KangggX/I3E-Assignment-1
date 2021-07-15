using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPad : MonoBehaviour
{
    public Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("activated", true);
        Debug.Log("hi");
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(3f);
        doorAnimator.SetBool("activated", false);
    }
}
