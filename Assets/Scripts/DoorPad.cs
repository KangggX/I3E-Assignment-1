using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPad : MonoBehaviour
{
    /// <summary>
    /// The door animator, drag from the game
    /// </summary>
    public Animator doorAnimator;

    /// <summary>
    /// Activates the animator boolean "activated" when triggered
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        doorAnimator.SetBool("activated", true);
        Debug.Log("hi");
        StartCoroutine(Countdown());
    }

    /// <summary>
    /// 3 seconds countdown timer
    /// </summary>
    /// <returns>Closing the door/gate</returns>
    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(3f);
        doorAnimator.SetBool("activated", false);
    }
}
