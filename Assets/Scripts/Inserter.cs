using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inserter : MonoBehaviour
{
    public GameObject door;

    public void Activate()
    {
        door.GetComponent<Animator>().SetBool("activated", true);
    }
}
