using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReturnMenu : MonoBehaviour {

    // Use this for initialization
    public Button myButton;
    private GameManager gm;
    public int i;
	void Start () {
        gm = GameObject.FindObjectOfType<GameManager>();
        myButton.onClick.AddListener(TaskMyButton);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskMyButton()
    { gm.LoadSceneLevel(i); }
}
