using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inserter : MonoBehaviour
{
    /// <summary>
    /// Door and Portal Gameobject to be dragged in
    /// </summary>
    public GameObject door;
    public GameObject portal;

    /// <summary>
    /// Activate the door Animator by setting the boolean of 'activated' to true
    /// </summary>
    public void Activate()
    {
        door.GetComponent<Animator>().SetBool("activated", true);
    }

    /// <summary>
    /// Activate the portal by setting the portal gameobject to active
    /// </summary>
    public void ActivatePortal()
    {
        portal.gameObject.SetActive(true);
    }
}
