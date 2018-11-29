using UnityEngine;

public interface IbuttonManager {

    void loadScene(string sceneName);

    void playAnimationOnInstructions();

	void restart();

	void quit();

}