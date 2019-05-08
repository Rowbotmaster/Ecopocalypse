using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController Instance;

    public float electricity = 1f;
    public float food = 1f;
    public float localTemp = 0.1f;
    public int backTrack = 0;
    public float latitudeFloat = 0f;
    public bool petrolCar = false;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
