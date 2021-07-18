using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(countdown());
    }

    private IEnumerator countdown()
    {
        yield return new WaitForSeconds(22f);
        SceneManager.LoadScene(0);
    }
}
