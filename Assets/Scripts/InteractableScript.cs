using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableScript : MonoBehaviour
{
    public PlayerData playerData;
    public int value;
    public int objectAmount;
    public string objectType;

    private bool isActivated = true;

    /// <summary>
    /// Method 
    /// </summary>
    public void Interacting()
    {
        if (gameObject.CompareTag("Collectible"))
        {
            Collectible();
        }
        else if (gameObject.CompareTag("Crate"))
        {
            Crate();
        }
        else if (gameObject.CompareTag("Inserter"))
        {
            Inserter();
        }
    }

    public void DetectionChecker(bool state)
    {
        if (gameObject.GetComponent<MeshRenderer>().materials[1] != null)
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

    /// <summary>
    /// To activated the animation of object tag Collectible
    /// </summary>
    private void Collectible()
    {
        gameObject.SetActive(false);
        PointGiver(objectType);
    }

    /// <summary>
    /// To activated the animation of object tag Crate
    /// </summary>
    private void Crate()
    {
        if(isActivated)
        {
            gameObject.GetComponent<Animator>().SetBool("activated", isActivated);
            isActivated = false;
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("activated", isActivated);
            isActivated = true;
        }
    }

    private void Inserter()
    {
        if (objectType == "Battery")
        {
            if (playerData.currentBatteryAmount == objectAmount)
            {
                gameObject.GetComponent<Inserter>().Activate();
            }
            
        }
        else if (objectType == "Card")
        {
            if (playerData.currentCardAmount == objectAmount)
            {
                gameObject.GetComponent<Inserter>().Activate();
            }
        }
        else if (objectType == "Fuse")
        {
            if (playerData.currentFuseAmount == objectAmount)
            {
                gameObject.GetComponent<Inserter>().Activate();
            }
        }
        else if (objectType == "AdvancedFuse")
        {
            if (playerData.currentAdvancedFuseAmount == objectAmount)
            {
                gameObject.GetComponent<Inserter>().Activate();
            }
        }
    }


    /// <summary>
    /// Give points to the player according to the object collected by type
    /// </summary>
    /// <param name="oType"></param>
    private void PointGiver(string oType)
    {
        if(oType == "Battery")
        {
            ++playerData.currentBatteryAmount;
        }
        else if(oType == "Card")
        {
            ++playerData.currentCardAmount;
        }
        else if (oType == "Fuse")
        {
            ++playerData.currentFuseAmount;
        }
        else if (oType == "AdvancedFuse")
        {
            ++playerData.currentAdvancedFuseAmount;
        }
    }
}
