using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour {
    //Behaviour h = (Behaviour)GetComponent ("Halo");
    //h.enabled = true;

    public GameObject showableObject;

    private GameObject[] allObjectsInTheScene;

    void OnMouseDown() {

        if (showableObject != null) {
            bool isActive = showableObject.activeSelf;
            allObjectsInTheScene = GameObject.FindGameObjectsWithTag ("Showable");

            foreach (GameObject obj in allObjectsInTheScene) {
                obj.SetActive (false);
            }

            if (isActive) {
                showableObject.SetActive (false);
            } else {
                showableObject.SetActive (true);              
            }

        }

    }

}