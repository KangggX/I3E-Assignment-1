using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    /// <summary>
    /// AudioMixer object to be dragged in
    /// </summary>
    public AudioMixer mixer;

    /// <summary>
    /// Function to adjust BGM using slider on Start Menu
    /// </summary>
    /// <param name="sliderValue"></param>
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("BGM", Mathf.Log10(sliderValue) * 20);
    }
}
