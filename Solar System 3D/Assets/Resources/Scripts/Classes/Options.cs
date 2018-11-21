using UnityEngine;
using UnityEngine.UI;

public class Options : OptionsAbstraction {

    public Slider volume;
    public Slider cameraSpeed;
    public Slider cameraSensitivity;
    public Dropdown qualitySettings;
    public GameObject message;
    public GameObject settingsMenu;

    void Start() {
        initializeVariables ();
        checkSettings ();
    }

    public override void initializeVariables ()
    {
        Cursor.visible = true;
        flagForSettings = -1;
    }

    public override void saveSettings() {
        int indexOfQuality = qualitySettings.value;
        AudioListener.volume = volume.value;
        QualitySettings.SetQualityLevel (indexOfQuality);
        PlayerPrefs.SetInt ("QualityLevel", indexOfQuality);
        PlayerPrefs.SetFloat ("Volume", volume.value);
        PlayerPrefs.SetFloat ("CameraSpeed", cameraSpeed.value);
        PlayerPrefs.SetFloat ("CameraSensitivity", cameraSensitivity.value);
        message.SetActive (true);
    }

    public override void playAnimationOnOptionsMenu() {
        flagForSettings++;

        if (flagForSettings % 2 == 0) {
            settingsMenu.GetComponent<Animation> ().Play ("Options in");
        } else {
            settingsMenu.GetComponent<Animation> ().Play ("Options out");
            message.SetActive (false);
        }

    }

    public override void checkSettings() {
        volume.value = PlayerPrefs.GetFloat("Volume", 1f);
        cameraSpeed.value = PlayerPrefs.GetFloat ("CameraSpeed", 0.5f);
        cameraSensitivity.value = PlayerPrefs.GetFloat ("CameraSensitivity", 0.5f);
        qualitySettings.value = PlayerPrefs.GetInt("QualityLevel", 2);  
        AudioListener.volume = volume.value;
        QualitySettings.SetQualityLevel (qualitySettings.value);
    }

}