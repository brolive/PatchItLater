using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

    public string levelName = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DoButton()
    {
        GameObject.Find("PanelFade").GetComponent<PanelFade>().FadeOut();
        GameManager.instance.AddTimer(2, GoToLevel);

        GameManager.instance.PlaySoundPlace();
    }

    public void GoToLevel()
    {

        SceneManager.LoadScene(levelName);
    }
}
