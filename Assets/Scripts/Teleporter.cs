using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject location;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = location.transform.position;
    }
}
