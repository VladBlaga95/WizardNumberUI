using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    static GameManager instance = null;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
    // Use this for initialization
    void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		
	}
  public void LoadSceneLevel(int index)
    {
        SceneManager.LoadScene(index);
       
    }
}
