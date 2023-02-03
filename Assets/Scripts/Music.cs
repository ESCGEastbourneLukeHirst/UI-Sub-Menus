using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Music : MonoBehaviour
{
    private float musicVolume;
    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private TextMeshProUGUI volumeTextUI = null;

    private void Start()
    {
        LoadValues();
    }

    public void VolumeSlider(float musicVolume)
    {
        volumeTextUI.text = musicVolume.ToString("0, 0");
    }
    public void SaveVolumeButton()
    {
        float musicVolume = volumeSlider.value;
        PlayerPrefs.SetFloat("musicVolume", musicVolume);
        LoadValues();
    }
    void LoadValues()
    {
        float musicVolume = PlayerPrefs.GetFloat("musicVolume");
        volumeSlider.value = musicVolume;
        AudioListener.volume = musicVolume;
    }
}
