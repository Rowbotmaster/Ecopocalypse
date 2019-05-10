using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarChoice : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ElectricCarChoice()
    {
        GameController.Instance.petrolCar = false;
        SceneManager.LoadScene(1);
    }

    public void PetrolCarChoice()
    {
        GameController.Instance.petrolCar = true;
        SceneManager.LoadScene(1);
    }
}
