using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public GameObject settingsPanel; // Paneli inspector'dan ekle
    public Slider volumeSlider; // Slider baðlantýsý

    private void Start()
    {
        settingsPanel.SetActive(false); // Baþlangýçta panel kapalý
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true); // Ayar menüsünü aç
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false); // Ayar menüsünü kapat
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume; // Ses seviyesini ayarla
    }
}
