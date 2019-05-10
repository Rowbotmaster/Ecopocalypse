using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitFunction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void doExitGame ()
    {
        Application.Quit();
	}
}
