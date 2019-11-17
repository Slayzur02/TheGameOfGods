using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{   
    public Toggle vibrateToggle;
    public AudioMixer audioMixer;
    public Slider slider;
    public bool canVibrate = true;

    void Start(){
        if (PlayerPrefs.GetString("Vibrate", "true")=="true")
        {
            vibrateToggle.isOn = true;
        }
        else vibrateToggle.isOn = false;
        slider.value = PlayerPrefs.GetFloat("VolumePref",1);
        audioMixer.SetFloat("Volume",Mathf.Log10(PlayerPrefs.GetFloat("VolumePref",1))*20);
    }
    public void SetVolume ()
    {
        audioMixer.SetFloat("Volume",Mathf.Log10(slider.value)*20);
        PlayerPrefs.SetFloat("VolumePref",slider.value);
    }

    public void toggleVibrate()
    {
        canVibrate = !canVibrate;
        if (canVibrate ==true)
        {
            PlayerPrefs.SetString("Vibrate", "true");
        }
        else PlayerPrefs.SetString("Vibrate", "false");
    }
}
