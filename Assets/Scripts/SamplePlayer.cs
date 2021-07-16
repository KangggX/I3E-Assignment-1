/******************************************************************************
Author: Elyas Chua-Aziz

Name of Class: DemoPlayer

Description of Class: This class will control the movement and actions of a 
                        player avatar based on user input.

Date Created: 09/06/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{
    /// <summary>
    /// The distance this player will travel per second.
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float rotationSpeed;

    /// <summary>
    /// The camera attached to the player model.
    /// Should be dragged in from Inspector.
    /// </summary>
    public Camera playerCamera;
    public string currentState;
    public string nextState;

    private GameObject lastInteractedCollectible;

    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        nextState = "Idle";
    }

    // Update is called once per frame
    private void Update()
    {
        if(nextState != currentState)
        {
            SwitchState();
        }

        CheckRotation();

        Raycast();
    }

    /// <summary>
    /// Sets the current state of the player
    /// and starts the correct coroutine.
    /// </summary>
    private void SwitchState()
    {
        StopCoroutine(currentState);

        currentState = nextState;
        StartCoroutine(currentState);
    }

    private IEnumerator Idle()
    {
        while(currentState == "Idle")
        {
            if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                nextState = "Moving";
            }
            yield return null;
        }
    }

    private IEnumerator Moving()
    {
        while (currentState == "Moving")
        {
            if (!CheckMovement())
            {
                nextState = "Idle";
            }
            yield return null;
        }
    }

    private void CheckRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        Vector3 playerRotation = transform.rotation.eulerAngles;
        playerRotation.y += mouseX;

        transform.rotation = Quaternion.Euler(playerRotation);

        Vector3 cameraRotation = playerCamera.transform.rotation.eulerAngles;
        cameraRotation.x -= mouseY;

        playerCamera.transform.rotation = Quaternion.Euler(cameraRotation);
    }

    /// <summary>
    /// Checks and handles movement of the player
    /// </summary>
    /// <returns>True if user input is detected and player is moved.</returns>
    private bool CheckMovement()
    {
        Vector3 newPos = transform.position;

        Vector3 xMovement = transform.right * Input.GetAxis("Horizontal");
        Vector3 zMovement = transform.forward * Input.GetAxis("Vertical");

        Vector3 movementVector = xMovement + zMovement;
        //Debug.Log(movementVector);
        //Vector3 movementVector = xMovement;

        if (movementVector.sqrMagnitude > 0)
        {
            movementVector *= moveSpeed * Time.deltaTime;
            newPos += movementVector;

            transform.position = newPos;
            return false;
        }
        else
        {
            return true;
        }

    }

    private void Raycast()
    {
        Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward * 16, Color.blue);
        RaycastHit hit;

        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, 10f))
        {
            GameObject objectTransform = hit.transform.gameObject;
            //Debug.Log(hit.transform.name);
            if (objectTransform.layer == LayerMask.NameToLayer("Collectible"))
            {
                //Debug.Log(objectTransform.GetComponent<MeshRenderer>().materials[1]);
                lastInteractedCollectible = objectTransform;
                lastInteractedCollectible.GetComponent<CollectibleScript>().detectionChecker(true);
            }
            else
            {
                lastInteractedCollectible.GetComponent<CollectibleScript>().detectionChecker(false);
            }
        }
    }
}
