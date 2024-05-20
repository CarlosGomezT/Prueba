using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderCriot : MonoBehaviour
{

    [SerializeField] private Slider _slider;
    [SerializeField] private TMP_Text sliderText;

    private void Update()
    {
        sliderText.text = _slider.value.ToString("0");
    }

    private void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            sliderText.text = v.ToString("0");
        });

        LoadVolumeSlider();
    }

    public void SaveVolumeSlider()
    {
        float volumeValue = _slider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
    }

    public void LoadVolumeSlider() 
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        _slider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
