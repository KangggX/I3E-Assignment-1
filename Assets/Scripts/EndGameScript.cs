using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGameScript : MonoBehaviour
{
    /// <summary>
    /// All TMP to be dragged in the End Scene
    /// </summary>
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;

    /// <summary>
    /// Start the coroutine upon loading the scene
    /// </summary>
    void Start()
    {
        StartCoroutine(opacityTime());
    }

    /// <summary>
    /// SetActive the different TMP every 4s and then load the Startmenu afterwards
    /// </summary>
    /// <returns></returns>
    private IEnumerator opacityTime()
    {
        yield return new WaitForSeconds(2f);
        text1.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);
        text2.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(0);
    }
}
