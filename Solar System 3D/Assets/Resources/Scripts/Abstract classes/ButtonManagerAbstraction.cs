using UnityEngine;

public abstract class ButtonManagerAbstraction : MonoBehaviour, IbuttonManager {

    public int instructionsIndex { get; set;}

    public abstract void loadScene(string sceneName);

    public abstract void playAnimationOnInstructions();

	public abstract void restart();

	public abstract void quit();

}