using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SFX : MonoBehaviour
{
    private float sfxVolume;

    [SerializeField] private Slider volumeSlider = null;

    [SerializeField] private TextMeshProUGUI volumeTextUI = null;

    private void Start()
    {
        LoadValues();
    }

    public void VolumeSlider(float sfxVolume)
    {
        volumeTextUI.text = sfxVolume.ToString("0, 0");
    }
    public void SaveVolumeButton()
    {
        float sfxVolume = volumeSlider.value;
        PlayerPrefs.SetFloat("sfxVolume", sfxVolume);
        LoadValues();
    }
    void LoadValues()
    {
        float sfxVolume = PlayerPrefs.GetFloat("sfxVolume");
        volumeSlider.value = sfxVolume;
        AudioListener.volume = sfxVolume;
    }
}
