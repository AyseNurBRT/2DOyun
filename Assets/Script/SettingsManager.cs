using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public GameObject settingsPanel; // Paneli inspector'dan ekle
    public Slider volumeSlider; // Slider ba�lant�s�

    private void Start()
    {
        settingsPanel.SetActive(false); // Ba�lang��ta panel kapal�
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true); // Ayar men�s�n� a�
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false); // Ayar men�s�n� kapat
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume; // Ses seviyesini ayarla
    }
}
