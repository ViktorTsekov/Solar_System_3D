using UnityEngine;

public abstract class OptionsAbstraction : MonoBehaviour, Iinitialize, Ioptions {

    public int flagForSettings { get; set;}

    public abstract void initializeVariables();

    public abstract void saveSettings();

    public abstract void playAnimationOnOptionsMenu();

    public abstract void checkSettings();

}