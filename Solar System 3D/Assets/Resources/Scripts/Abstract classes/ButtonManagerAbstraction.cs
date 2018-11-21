using UnityEngine;

public abstract class ButtonManagerAbstraction : MonoBehaviour, IbuttonManager {

    public abstract void loadScene(string sceneName);

	public abstract void restart();

	public abstract void quit();

}